using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Validators
{
    /// <summary>
    /// Validates FPTU-style student code: 2 letters + 5 digits (e.g. SE19886, CE18793)
    /// </summary>
    public class FptuStudentCodeAttribute : ValidationAttribute
    {
        private static readonly Regex Pattern =
            new(@"^[A-Z]{2}\d{5}$", RegexOptions.Compiled);

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            if (value is null) return ValidationResult.Success; // NotEmpty handles null

            var code = value.ToString()!;
            return Pattern.IsMatch(code)
                ? ValidationResult.Success
                : new ValidationResult(
                    "Student code must follow FPTU format: 2 uppercase letters + 5 digits (e.g. SE19886)");
        }
    }
}
