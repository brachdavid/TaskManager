using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.CustomValidations
{
    /// <summary>
    /// Validates that the first character of the string is uppercase.
    /// </summary>
    public class StartsWithUppercaseAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string str && !string.IsNullOrEmpty(str))
            {
                if (char.IsUpper(str[0]))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage ?? "The first character must be uppercase.");
                }
            }

            return new ValidationResult(ErrorMessage ?? "A valid string is required.");
        }
    }
}
