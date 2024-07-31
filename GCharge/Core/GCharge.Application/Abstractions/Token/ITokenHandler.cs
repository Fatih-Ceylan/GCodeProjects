using GCharge.Domain.Entities.Identity;
using Utilities.Core.UtilityApplication.DTOs.Identity;

namespace GCharge.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        TokenDTO CreateAccessToken(int second, AppUser appUser);

        string CreateRefreshToken();
    }
}