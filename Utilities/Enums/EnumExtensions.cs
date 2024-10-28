using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection;

namespace TaskManager.Utilities.Enums
{
    /// <summary>
    /// Provides extension methods for Enum types.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Retrieves the display name of an enum value from the DisplayAttribute.
        /// If the attribute is not present, returns the enum value's name.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <returns>The display name of the enum value.</returns>
        public static string GetDisplayName(this Enum value)
        {
            ArgumentNullException.ThrowIfNull(value);

            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttribute<DisplayAttribute>();
            return attribute?.GetName() ?? value.ToString();
        }

        /// <summary>
        /// Retrieves the description of an enum value from the DescriptionAttribute.
        /// If the attribute is not present, returns an empty string.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <returns>The description of the enum value.</returns>
        public static string GetDescription(this Enum value)
        {
            ArgumentNullException.ThrowIfNull(value);

            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? string.Empty;
        }
    }
}
