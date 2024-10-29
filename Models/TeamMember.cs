using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TaskManager.Utilities.CustomValidations;
using TaskManager.Utilities.Enums;

namespace TaskManager.Models
{
    /// <summary>
    /// Represents a team member entity in the advertising agency's database, inheriting from IdentityUser.
    /// </summary>
    public class TeamMember : IdentityUser
    {
        /// <summary>
        /// The first name of the team member.
        /// </summary>
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "First name can have a maximum of 100 characters.")]
        [RegularExpression(@"^[a-zA-Z·-û¡-é]+([ '-][a-zA-Z·-û¡-é]+)*$", ErrorMessage = "First name contains invalid characters.")]
        [StartsWithUppercase(ErrorMessage = "First name must start with an uppercase letter.")]
        public required string FirstName { get; set; }

        /// <summary>
        /// The last name of the team member.
        /// </summary>
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name can have a maximum of 100 characters.")]
        [RegularExpression(@"^[a-zA-Z·-û¡-é]+([ '-][a-zA-Z·-û¡-é]+)*$", ErrorMessage = "Last name contains invalid characters.")]
        [StartsWithUppercase(ErrorMessage = "Last name must start with an uppercase letter.")]
        public required string LastName { get; set; }

        /// <summary>
        /// The birth date of the team member.
        /// </summary>
        [Required(ErrorMessage = "Birth date is required.")]
        [DataType(DataType.Date)]
        [MinimumAge(18, ErrorMessage = "Team member must be at least 18 years old.")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The job position of the team member (default value - Project Manager).
        /// </summary>
        [Required(ErrorMessage = "Work position is required.")]
        public WorkPosition WorkPosition { get; set; } = WorkPosition.ProjectManager;

        /// <summary>
        /// The skill level of the team member in their respective work area (default value - Junior).
        /// </summary>
        [Required(ErrorMessage = "Skill level is required.")]
        public SkillLevel SkillLevel { get; set; } = SkillLevel.Junior;

        /// <summary>
        /// The registration date of the team member.
        /// </summary>
        public DateTime RegistrationDate { get; init; }

        /// <summary>
        /// Collection of tasks assigned to the team member.
        /// </summary>
        public List<TaskItem> Tasks { get; set; }

        /// <summary>
        /// Collection of clients managed by the Project Manager.
        /// </summary>
        public List<Client> ManagedClients { get; set; }

        /// <summary>
        /// Constructor that dynamically sets the registration date and initializes empty collections for tasks and clients.
        /// </summary>
        public TeamMember()
        {
            // Dynamically set the registration date to the current UTC time
            RegistrationDate = DateTime.UtcNow;

            // Initialize empty collections to avoid null references
            Tasks = [];
            ManagedClients = [];
        }
    }
}
