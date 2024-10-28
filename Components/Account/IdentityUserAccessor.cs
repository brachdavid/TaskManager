using Microsoft.AspNetCore.Identity;
using TaskManager.Data;

namespace TaskManager.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<TeamMember> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<TeamMember> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
