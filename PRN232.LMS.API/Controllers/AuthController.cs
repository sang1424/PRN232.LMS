using Microsoft.AspNetCore.Mvc;
using PRN232.LMS.API.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.Models.Requests;
using System.Linq;
using System.Threading.Tasks;

namespace PRN232.LMS.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
            => _authService = authService;

        /// <summary>Login và nhận JWT token</summary>
        [HttpPost("login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Validation failed",
                    Errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                });

            var result = await _authService.LoginAsync(request);
            if (result == null)
                return Unauthorized(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Invalid username or password"
                });

            return Ok(new ApiResponse<object>
            {
                Success = true,
                Message = "Login successful",
                Data = result
            });
        }

        /// <summary>Dùng refresh token để lấy access token mới</summary>
        [HttpPost("refresh-token")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Refresh token is required"
                });

            var result = await _authService.RefreshTokenAsync(request.RefreshToken);
            if (result == null)
                return Unauthorized(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Invalid or expired refresh token"
                });

            return Ok(new ApiResponse<object>
            {
                Success = true,
                Message = "Token refreshed successfully",
                Data = result
            });
        }
    }
}
