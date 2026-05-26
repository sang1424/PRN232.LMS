using Microsoft.AspNetCore.Mvc;
using PRN232.LMS.API.Common;
using PRN232.LMS.Repositories.Helpers;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.Models.Requests;
using PRN232.LMS.Services.Models.Responses;

namespace PRN232.LMS.API.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;
        public CoursesController(ICourseService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QueryParameters query)
        {
            var result = await _service.GetAllAsync(query);

            object data;
            if (!string.IsNullOrEmpty(query.Fields))
            {
                var fields = query.Fields.ToLower()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToHashSet();

                data = result.Items.Select(x =>
                {
                    var dict = new Dictionary<string, object?>();
                    if (fields.Contains("courseid")) dict["courseId"] = x.CourseId;
                    if (fields.Contains("coursename")) dict["courseName"] = x.CourseName;
                    if (fields.Contains("semesterid")) dict["semesterId"] = x.SemesterId;
                    if (fields.Contains("semester") && x.Semester != null)
                        dict["semester"] = x.Semester;
                    return dict;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Course not found"
                });
            return Ok(new ApiResponse<CourseResponse> { Success = true, Data = item });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCourseRequest request)
        {
            var created = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetById),
                new { id = created.CourseId },
                new ApiResponse<CourseResponse> { Success = true, Data = created });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCourseRequest request)
        {
            var updated = await _service.UpdateAsync(id, request);
            if (!updated)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Course not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
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
