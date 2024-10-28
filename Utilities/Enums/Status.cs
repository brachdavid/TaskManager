using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.Enums
{
    /// <summary>
    /// Status options designated for individual tasks.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Active (incomplete) task.
        /// </summary>
        [Display(Name = "Active")]
        Active = 1,

        /// <summary>
        /// Closed (completed) task.
        /// </summary>
        [Display(Name = "Closed")]
        Closed = 2
    }
}
