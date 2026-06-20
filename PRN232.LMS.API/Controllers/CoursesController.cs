using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRN232.LMS.API.Common;
using PRN232.LMS.Repositories.Helpers;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.Models.Requests;
using PRN232.LMS.Services.Models.Responses;
using PRN232.LMS.Services.Services;

namespace PRN232.LMS.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/courses")]
    [Authorize]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IEnrollmentService _enrollmentService;

        public CoursesController(
            ICourseService courseService,
            IEnrollmentService enrollmentService)
        {
            _courseService = courseService;
            _enrollmentService = enrollmentService;
        }

        // ── GET /api/v1/courses ──────────────────────────────────────────────
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QueryParameters query)
        {
            var result = await _courseService.GetAllAsync(query);

            object data;
            if (!string.IsNullOrEmpty(query.Fields))
            {
                var fields = query.Fields.ToLower()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToHashSet();

                // Tự động expand semester nếu fields yêu cầu
                if (fields.Contains("semester") && string.IsNullOrEmpty(query.Expand))
                    query.Expand = "semester";

                data = result.Items.Select(x =>
                {
                    var dict = new Dictionary<string, object?>();
                    if (fields.Contains("courseid")) dict["courseId"] = x.CourseId;
                    if (fields.Contains("coursename")) dict["courseName"] = x.CourseName;
                    if (fields.Contains("semesterid")) dict["semesterId"] = x.SemesterId;
                    if (fields.Contains("semester") && x.Semester != null)
                        dict["semester"] = x.Semester;

                    return dict.Count == 0
                        ? new Dictionary<string, object?>
                        {
                            ["courseId"] = x.CourseId,
                            ["courseName"] = x.CourseName,
                            ["semesterId"] = x.SemesterId
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

        // ── GET /api/v1/courses/{id} ─────────────────────────────────────────
        [HttpGet("{id:int}", Name = "GetCourseById")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var item = await _courseService.GetByIdAsync(id);
            if (item == null)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Course not found"
                });
            return Ok(new ApiResponse<CourseResponse> { Success = true, Data = item });
        }

        // ── GET /api/v1/courses/{id}/enrollments ─────────────────────────────
        [HttpGet("{id:int}/enrollments")]
        public async Task<IActionResult> GetEnrollments(
            [FromRoute] int id,
            [FromQuery] QueryParameters query)
        {
            var result = await _enrollmentService.GetByCourseIdAsync(id, query);

            if (result == null)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Course not found"
                });

            return Ok(new ApiResponse<object>
            {
                Success = true,
                Message = "Enrollments retrieved successfully",
                Data = result.Items,
                Pagination = new
                {
                    result.Page,
                    result.PageSize,
                    result.TotalItems,
                    result.TotalPages
                }
            });
        }

        // ── POST /api/v1/courses ─────────────────────────────────────────────
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseRequest request)
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

            var created = await _courseService.CreateAsync(request);
            return CreatedAtRoute("GetCourseById",
                new { version = "1", id = created.CourseId },
                new ApiResponse<CourseResponse> { Success = true, Data = created });
        }

        // ── PUT /api/v1/courses/{id} ─────────────────────────────────────────
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            [FromRoute] int id,
            [FromBody] UpdateCourseRequest request)
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

            var updated = await _courseService.UpdateAsync(id, request);
            if (!updated)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Course not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Updated successfully" });
        }

        // ── DELETE /api/v1/courses/{id} — CHỈ ADMIN ──────────────────────────
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _courseService.DeleteAsync(id);
            if (!deleted)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Course not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Deleted successfully" });
        }
    }
}
