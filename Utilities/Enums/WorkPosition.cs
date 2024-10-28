using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskManager.Utilities.Enums
{
    /// <summary>
    /// Job position options designed for employees of the advertising agency.
    /// </summary>
    public enum WorkPosition
    {
        /// <summary>
        /// The Project Manager oversees projects, coordinates the team, and ensures everything runs according to plan.
        /// </summary>
        [Display(Name = "Project Manager")]
        [Description("Manages and coordinates all aspects of the project. Ensures the team meets deadlines, allocates resources, and communicates with management and clients to ensure successful project execution.")]
        ProjectManager = 1,

        /// <summary>
        /// The Account Manager manages client relationships, mediates their requirements and expectations.
        /// </summary>
        [Display(Name = "Account Manager")]
        [Description("Builds and maintains relationships with clients. Listens to their needs, provides regular updates on project progress, and ensures the team meets the client's expectations and goals.")]
        AccountManager = 2,

        /// <summary>
        /// The Marketing Strategist designs the strategy and tactics of campaigns in line with project goals.
        /// </summary>
        [Display(Name = "Marketing Strategist")]
        [Description("Develops marketing strategies for campaigns based on market analysis and client needs. Defines goals, target segments, and key tactics to achieve campaign results.")]
        MarketingStrategist = 3,

        /// <summary>
        /// The Graphic Designer creates visual materials and resources for the campaign.
        /// </summary>
        [Display(Name = "Graphic Designer")]
        [Description("Creates visual elements of the campaign, including graphics for social media, advertisements, and other materials. Works according to team assignments and follows the client's visual identity.")]
        GraphicDesigner = 4,

        /// <summary>
        /// The Copywriter creates textual content that supports the visual concept of the campaign.
        /// </summary>
        [Display(Name = "Copywriter")]
        [Description("Writes texts for campaigns, including slogans, advertising copy, and social media posts. Collaborates with designers and strategists to ensure the campaign content is consistent and persuasive.")]
        Copywriter = 5,

        /// <summary>
        /// The Marketing Specialist focuses on executing specific marketing tasks, such as SEO, social media, or PPC campaigns.
        /// </summary>
        [Display(Name = "Marketing Specialist")]
        [Description("Carries out specific marketing tasks according to the strategist's instructions. May specialize in individual channels such as social media, SEO, PPC campaigns, and contributes to the overall effectiveness of the campaign.")]
        MarketingSpecialist = 6
    }
}
