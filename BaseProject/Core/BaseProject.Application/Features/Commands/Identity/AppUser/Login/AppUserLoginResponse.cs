using Utilities.Core.UtilityApplication.DTOs.Identity;

namespace BaseProject.Application.Features.Commands.Identity.AppUser.Login
{
    public class AppUserLoginResponse
    {
        public TokenDTO Token { get; set; }

        public string BaseDbName { get; set; }

        public string Message { get; set; } = "Authentication Succeed";
    }
}