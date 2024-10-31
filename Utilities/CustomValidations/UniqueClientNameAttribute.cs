using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TaskManager.Data;

namespace TaskManager.Utilities.CustomValidations
{
    public class UniqueClientNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var dbContext = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext))!;
            var clientName = value.ToString();

            var existingClient = dbContext.Clients
                .AsNoTracking()
                .FirstOrDefault(c => c.Name == clientName);

            if (existingClient != null)
            {
                return new ValidationResult("A client with this name already exists.");
            }

            return ValidationResult.Success;
        }
    }
}
