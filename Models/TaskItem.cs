using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskManager.Utilities.CustomValidations;
using TaskManager.Utilities.Enums;

namespace TaskManager.Models
{
    /// <summary>
    /// Represents a task entity in the database.
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// Unique identifier of the task.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Title of the task.
        /// </summary>
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(200, ErrorMessage = "Title can have a maximum of 200 characters.")]
        [StartsWithUppercase(ErrorMessage = "Title must start with an uppercase letter.")]
        public required string Title { get; set; }

        /// <summary>
        /// Description of the task.
        /// </summary>
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(1000, ErrorMessage = "Description can have a maximum of 1000 characters.")]
        [StartsWithUppercase(ErrorMessage = "Description must start with an uppercase letter.")]
        public required string Description { get; set; }

        /// <summary>
        /// Expected latest due date for task completion.
        /// </summary>
        [Required(ErrorMessage = "Due date is required.")]
        [DataType(DataType.Date)]
        [DueDate(ErrorMessage = "Due date cannot be in the past.")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Registration date of the new task.
        /// </summary>
        public DateTime StartDate { get; init; }

        /// <summary>
        /// Actual completion date of the task.
        /// </summary>
        public DateTime? CompletedDate { get; private set; }

        /// <summary>
        /// Private field to store the current status of the task.
        /// </summary>
        private Status _status;

        /// <summary>
        /// Status of the task.
        /// </summary>
        public Status Status
        {
            get => _status;
            set
            {
                // If the current status is Closed, do not allow further status changes.
                if (_status == Status.Closed)
                {
                    return;
                }

                // Allow status change if not Closed.
                _status = value;

                if (_status == Status.Closed)
                {
                    CompletedDate = DateTime.UtcNow;
                }
            }
        }

        /// <summary>
        /// Unique identifier of the client under which the task falls.
        /// </summary>
        [Required(ErrorMessage = "Client ID is required.")]
        public required int ClientId { get; set; }

        /// <summary>
        /// Client under which the task falls.
        /// </summary>
        [Required(ErrorMessage = "Client is required.")]
        [ForeignKey("ClientId")]
        public Client Client { get; set; } = null!;

        /// <summary>
        /// Unique identifier of the user to whom the task was assigned.
        /// </summary>
        public string? TeamMemberId { get; set; }

        /// <summary>
        /// User to whom the task was assigned.
        /// </summary>
        [ForeignKey("TeamMemberId")]
        public TeamMember? TeamMember { get; set; }

        /// <summary>
        /// Constructor dynamically sets the creation date of the task and initializes the task status to "Active".
        /// </summary>
        public TaskItem()
        {
            // Dynamically set the creation date of the new task.
            StartDate = DateTime.UtcNow;
            // Predefined task status.
            Status = Status.Active;
        }
    }
}
