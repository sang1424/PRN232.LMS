using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRN232.LMS.API.Common;
using PRN232.LMS.Repositories.Helpers;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.Models.Requests;
using PRN232.LMS.Services.Models.Responses;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PRN232.LMS.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/students")]
    [Authorize]   // Tất cả endpoint đều cần đăng nhập
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
            => _studentService = studentService;

        /// <summary>Lấy danh sách sinh viên (search, sort, paging, fields, expand)</summary>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetAll(
            [FromQuery] QueryParameters query,
            [FromHeader(Name = "X-Request-Id")] string? requestId = null)
        {
            var result = await _studentService.GetAllAsync(query);

            object data;
            if (!string.IsNullOrEmpty(query.Fields))
            {
                var fields = query.Fields.ToLower()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToHashSet();

                data = result.Items.Select(s =>
                {
                    var dict = new Dictionary<string, object?>();
                    if (fields.Contains("studentid")) dict["studentId"] = s.StudentId;
                    if (fields.Contains("fullname")) dict["fullName"] = s.FullName;
                    if (fields.Contains("email")) dict["email"] = s.Email;
                    if (fields.Contains("dateofbirth")) dict["dateOfBirth"] = s.DateOfBirth;
                    return dict.Count == 0
                        ? new Dictionary<string, object?>
                        {
                            ["studentId"] = s.StudentId,
                            ["fullName"] = s.FullName,
                            ["email"] = s.Email,
                            ["dateOfBirth"] = s.DateOfBirth
                        }
                        : dict;
                });
            }
            else
            {
                data = result.Items;
            }

            return Ok(new ApiResponse<object>
            {
                Success = true,
                Data = data,
                Pagination = new
                {
                    result.Page,
                    result.PageSize,
                    result.TotalItems,
                    result.TotalPages
                }
            });
        }

        /// <summary>Lấy thông tin sinh viên theo ID</summary>
        [HttpGet("{id:int}", Name = "GetStudentById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var student = await _studentService.GetByIdAsync(id);
            if (student == null)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Student not found"
                });
            return Ok(new ApiResponse<StudentResponse> { Success = true, Data = student });
        }

        /// <summary>Tạo sinh viên mới</summary>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] CreateStudentRequest request)
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

            var created = await _studentService.CreateAsync(request);
            return CreatedAtRoute("GetStudentById",
                new { version = "1", id = created.StudentId },
                new ApiResponse<StudentResponse> { Success = true, Data = created });
        }

        /// <summary>Cập nhật sinh viên</summary>
        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(
            [FromRoute] int id,
            [FromBody] UpdateStudentRequest request)
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

            var updated = await _studentService.UpdateAsync(id, request);
            if (!updated)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Student not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Updated successfully" });
        }

        /// <summary>Xóa sinh viên — CHỈ ADMIN</summary>
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]   // Admin-only endpoint
        [ProducesResponseType(200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _studentService.DeleteAsync(id);
            if (!deleted)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Student not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Deleted successfully" });
        }
    }
}
