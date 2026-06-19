using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PRN232.LMS.Repositories.Data;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.Models.Requests;
using PRN232.LMS.Services.Models.Responses;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;

        // In-memory refresh token store (đủ cho lab, production dùng DB)
        private static readonly Dictionary<string, (int UserId, string Role, DateTime Expiry)>
            _refreshTokens = new();

        public AuthService(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<AuthResponse?> LoginAsync(LoginRequest request)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Username == request.Username);

            if (user == null) return null;

            // Verify password bằng BCrypt
            bool valid = BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash);
            if (!valid) return null;

            return GenerateTokens(user.UserId, user.Username, user.Role);
        }

        public async Task<AuthResponse?> RefreshTokenAsync(string refreshToken)
        {
            if (!_refreshTokens.TryGetValue(refreshToken, out var data))
                return null;

            if (data.Expiry < DateTime.UtcNow)
            {
                _refreshTokens.Remove(refreshToken);
                return null;
            }

            var user = await _context.Users.FindAsync(data.UserId);
            if (user == null) return null;

            // Xóa refresh token cũ
            _refreshTokens.Remove(refreshToken);

            return GenerateTokens(user.UserId, user.Username, user.Role);
        }

        // ── Private helpers ───────────────────────────────────────────────
        private AuthResponse GenerateTokens(int userId, string username, string role)
        {
            var accessToken = GenerateJwt(userId, username, role);
            var refreshToken = GenerateRefreshToken();

            // Lưu refresh token 7 ngày
            _refreshTokens[refreshToken] = (userId, role, DateTime.UtcNow.AddDays(7));

            return new AuthResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiresIn = 3600,
                Role = role
            };
        }

        private string GenerateJwt(int userId, string username, string role)
        {
            var jwtKey = _config["Jwt:Key"]!;
            var jwtIssuer = _config["Jwt:Issuer"]!;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, username),
                new Claim(ClaimTypes.Role, role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtIssuer,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private static string GenerateRefreshToken()
        {
            var bytes = RandomNumberGenerator.GetBytes(64);
            return Convert.ToBase64String(bytes);
        }
    }
}
