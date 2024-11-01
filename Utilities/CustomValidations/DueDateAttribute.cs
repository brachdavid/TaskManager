using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.CustomValidations
{
    /// <summary>
    /// Validates that the due date is not in the past.
    /// </summary>
    public class DueDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                // [Required] attribute takes care of checking the null value.
                return ValidationResult.Success;
            }

            if (value is not DateTime dueDate)
            {
                return new ValidationResult("Invalid date format.");
            }

            // Compare with today's date
            var today = DateTime.UtcNow.Date;
            var dueDateDate = dueDate.Date;

            if (dueDateDate < today)
            {
                return new ValidationResult(ErrorMessage ?? "Due date cannot be in the past.");
            }

            return ValidationResult.Success;
        }
    }
}
