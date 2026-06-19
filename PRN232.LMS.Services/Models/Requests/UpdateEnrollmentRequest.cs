using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Models.Requests
{
    public class UpdateEnrollmentRequest
    {
        [Required]
        [RegularExpression("^(Active|Completed|Dropped)$",
            ErrorMessage = "Status must be Active, Completed, or Dropped")]
        public string Status { get; set; } = string.Empty;
    }
}
