using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.CustomValidations
{
    /// <summary>
    /// Validates that the user is at least a specified minimum age.
    /// </summary>
    public class MinimumAgeAttribute(int minimumAge) : ValidationAttribute
    {
        private readonly int _minimumAge = minimumAge;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;

                if (dateOfBirth.Date > today.AddYears(-age)) age--;

                if (age >= _minimumAge)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage ?? $"You must be at least {_minimumAge} years old.");
                }
            }

            return new ValidationResult(ErrorMessage ?? "A valid date of birth is required.");
        }
    }

}
