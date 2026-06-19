using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Models.Requests
{
    public class CreateEnrollmentRequest
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "StudentId must be > 0")]
        public int StudentId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "CourseId must be > 0")]
        public int CourseId { get; set; }

        public DateTime EnrollDate { get; set; } = DateTime.UtcNow;

        [Required]
        [RegularExpression("^(Active|Completed|Dropped)$",
            ErrorMessage = "Status must be Active, Completed, or Dropped")]
        public string Status { get; set; } = "Active";
    }
}
