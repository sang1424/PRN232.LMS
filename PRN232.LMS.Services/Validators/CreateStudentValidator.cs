using FluentValidation;
using PRN232.LMS.Services.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Validators
{
    public class CreateStudentValidator : AbstractValidator<CreateStudentRequest>
    {
        public CreateStudentValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full name is required")
                .Length(2, 100).WithMessage("Full name must be 2-100 characters")
                .Matches(@"^[\p{L}\s]+$").WithMessage("Full name must contain only letters and spaces");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format")
                .MaximumLength(100);

            RuleFor(x => x.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required")
                .LessThan(DateTime.Now.AddYears(-16))
                    .WithMessage("Student must be at least 16 years old")
                .GreaterThan(new DateTime(1900, 1, 1))
                    .WithMessage("Date of birth is not valid");
        }
    }
}
