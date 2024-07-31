using Utilities.Core.UtilityApplication.DTOs.Identity;

namespace Platform.Application.Features.Commands.Identity.AppUser.Login
{
    public class AppUserLoginResponse
    {
        public TokenDTO Token { get; set; }
        public string Message { get; set; } = "Authentication Succeed";
    }
}