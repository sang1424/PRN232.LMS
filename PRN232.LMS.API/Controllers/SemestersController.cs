using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRN232.LMS.API.Common;
using PRN232.LMS.Repositories.Helpers;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.Models.Requests;
using PRN232.LMS.Services.Models.Responses;

namespace PRN232.LMS.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/semesters")]
    [Authorize]
    public class SemestersController : ControllerBase
    {
        private readonly ISemesterService _service;
        public SemestersController(ISemesterService service) => _service = service;

        // ── GET /api/v1/semesters ────────────────────────────────────────────
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
                    if (fields.Contains("semesterid")) dict["semesterId"] = x.SemesterId;
                    if (fields.Contains("semestername")) dict["semesterName"] = x.SemesterName;
                    if (fields.Contains("startdate")) dict["startDate"] = x.StartDate;
                    if (fields.Contains("enddate")) dict["endDate"] = x.EndDate;
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

        // ── GET /api/v1/semesters/{id} ───────────────────────────────────────
        [HttpGet("{id:int}", Name = "GetSemesterById")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Semester not found"
                });
            return Ok(new ApiResponse<SemesterResponse> { Success = true, Data = item });
        }

        // ── POST /api/v1/semesters ───────────────────────────────────────────
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSemesterRequest request)
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

            var created = await _service.CreateAsync(request);
            return CreatedAtRoute("GetSemesterById",
                new { version = "1", id = created.SemesterId },
                new ApiResponse<SemesterResponse> { Success = true, Data = created });
        }

        // ── PUT /api/v1/semesters/{id} ───────────────────────────────────────
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            [FromRoute] int id,
            [FromBody] UpdateSemesterRequest request)
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

            var updated = await _service.UpdateAsync(id, request);
            if (!updated)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Semester not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Updated successfully" });
        }

        // ── DELETE /api/v1/semesters/{id} — CHỈ ADMIN ───────────────────────
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Semester not found"
                });
            return Ok(new ApiResponse<object> { Success = true, Message = "Deleted successfully" });
        }
    }
}
