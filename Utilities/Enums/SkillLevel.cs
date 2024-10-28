using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.Enums
{
    /// <summary>
    /// Skill level options for employees of the advertising agency
    /// </summary>
    public enum SkillLevel
    {
        /// <summary>
        /// Level suitable for inexperienced or less experienced employees of the advertising agency
        /// </summary>
        [Display(Name = "Junior")]
        Junior = 1,

        /// <summary>
        /// Level suitable for intermediate employees of the advertising agency
        /// </summary>
        [Display(Name = "Intermediate")]
        Intermediate = 2,

        /// <summary>
        /// Level suitable for experienced employees of the advertising agency
        /// </summary>
        [Display(Name = "Senior")]
        Senior = 3
    }
}
