using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskManager.Utilities.CustomValidations;
using TaskManager.Utilities.Enums;

namespace TaskManager.Models
{
    /// <summary>
    /// Represents a client of the advertising agency.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Unique identifier of the client.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the company that is a client of the advertising agency.
        /// </summary>
        [Required(ErrorMessage = "Client name is required.")]
        [StringLength(200, ErrorMessage = "Client name can have a maximum of 200 characters.")]
        [StartsWithUppercase(ErrorMessage = "Client name must start with an uppercase letter.")]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the company that is a client of the advertising agency.
        /// </summary>
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(1000, ErrorMessage = "Description can have a maximum of 1000 characters.")]
        public required string Description { get; set; }

        /// <summary>
        /// Industry of the advertising agency's client.
        /// </summary>
        [Required(ErrorMessage = "Industry is required.")]
        public Industry Industry { get; set; } = Industry.Technology;

        /// <summary>
        /// Contact person with whom the advertising agency will interact.
        /// </summary>
        [Required(ErrorMessage = "Contact person is required.")]
        [StringLength(100, ErrorMessage = "Contact person name can have a maximum of 100 characters.")]
        [RegularExpression(@"^[a-zA-Zá-žÁ-Ž\s]+$", ErrorMessage = "Contact person name contains invalid characters.")]
        [StartsWithUppercase(ErrorMessage = "Contact person name must start with an uppercase letter.")]
        public required string ContactPerson { get; set; }

        /// <summary>
        /// Email of the contact person or client.
        /// </summary>
        [Required(ErrorMessage = "Contact email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public required string ContactEmail { get; set; }

        /// <summary>
        /// Phone number of the client or contact person.
        /// </summary>
        [Required(ErrorMessage = "Contact phone is required.")]
        [Phone(ErrorMessage = "Enter the phone number in the correct format.")]
        public required string ContactPhone { get; set; }

        /// <summary>
        /// Start date of cooperation with the client.
        /// </summary>
        public DateTime StartDate { get; init; }

        /// <summary>
        /// Collection of tasks assigned to this client.
        /// </summary>
        public List<TaskItem> Tasks { get; set; }

        /// <summary>
        /// ID of the Project Manager assigned to the client.
        /// </summary>
        public string? ProjectManagerId { get; set; }

        /// <summary>
        /// Navigation property for the project manager.
        /// </summary>
        [ForeignKey("ProjectManagerId")]
        public TeamMember? ProjectManager { get; set; }

        /// <summary>
        /// Constructor that dynamically sets the start date and initializes empty collections for tasks.
        /// </summary>
        public Client()
        {
            // Dynamically set the start date to the current UTC time
            StartDate = DateTime.UtcNow;

            // Initialize empty collections to avoid null references
            Tasks = [];
        }
    }
}
