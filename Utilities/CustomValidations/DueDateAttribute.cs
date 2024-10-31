using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.CustomValidations
{
    /// <summary>
    /// Validates that the due date is not in the past and not before the start date.
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

            // Gett an instance of an object that is validated
            var instance = validationContext.ObjectInstance;
            var type = instance.GetType();

            // Gett property StartDate
            var startDateProperty = type.GetProperty("StartDate");
            if (startDateProperty == null)
            {
                return new ValidationResult("StartDate property not found.");
            }

            var startDateValue = startDateProperty.GetValue(instance);

            if (startDateValue is not DateTime startDate)
            {
                return new ValidationResult("Invalid StartDate format.");
            }

            // Porovnání dat
            var today = DateTime.UtcNow.Date;
            var dueDateDate = dueDate.Date;
            var startDateDate = startDate.Date;

            if (dueDateDate < today)
            {
                return new ValidationResult(ErrorMessage ?? "Due date cannot be in the past or before the start date.");
            }

            if (dueDateDate < startDateDate)
            {
                return new ValidationResult(ErrorMessage ?? "Due date cannot be in the past or before the start date.");
            }

            return ValidationResult.Success;
        }
    }
}
