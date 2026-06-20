using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Validators
{
    /// Example valid:   nguyenvana@student.lms.edu.vn
    /// Example invalid: nguyenvana@gmail.com
    /// </summary>
    public class SchoolEmailAttribute : ValidationAttribute
    {
        private const string AllowedDomain = "student.lms.edu.vn";

        private static readonly Regex Pattern =
            new(@"^[a-zA-Z0-9._%+-]+@student\.lms\.edu\.vn$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            if (value is null)
                return ValidationResult.Success; // [Required] sẽ xử lý null

            var email = value.ToString()!;

            return Pattern.IsMatch(email)
                ? ValidationResult.Success
                : new ValidationResult(
                    $"Email must use the school domain: '@{AllowedDomain}' (e.g. yourname@{AllowedDomain})");
        }
    }
}
