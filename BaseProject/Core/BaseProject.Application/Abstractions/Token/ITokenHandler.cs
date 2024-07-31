using BaseProject.Domain.Entities.Identity;
using Utilities.Core.UtilityApplication.DTOs.Identity;

namespace BaseProject.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        TokenDTO CreateAccessToken(int second, AppUser appUser, string urlPath, string masterCompanyIdFromPlatform);
        string CreateRefreshToken();
    }
}