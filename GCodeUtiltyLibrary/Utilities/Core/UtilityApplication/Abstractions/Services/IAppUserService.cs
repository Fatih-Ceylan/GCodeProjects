using Utilities.Core.UtilityDomain.Entities.Identity;
using Utilities.Core.UtilityApplication.DTOs.Identity.AppUser;

namespace Utilities.Core.UtilityApplication.Absractions.Services
{
    public interface IAppUserService
    {
        Task<CreateUserResponseDTO> CreateAsync(CreateUserRequestDTO model);
        Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    }
}
