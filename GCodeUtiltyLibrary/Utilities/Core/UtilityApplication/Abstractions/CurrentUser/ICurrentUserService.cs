using Utilities.Core.UtilityApplication.DTOs.Identity.AppUser;

namespace Utilities.Core.UtilityApplication.Abstractions.CurrentUser
{
    public interface ICurrentUserService
    {
        Task<CurrentUserDTO> GetCurrentUser();
    }
}
