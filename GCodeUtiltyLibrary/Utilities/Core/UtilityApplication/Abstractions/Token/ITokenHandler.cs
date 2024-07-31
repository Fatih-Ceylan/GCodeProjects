using Utilities.Core.UtilityApplication.DTOs.Identity;

namespace Utilities.Core.UtilityApplication.Absractions.Token
{
    public interface ITokenHandler
    {
        TokenDTO CreateAccessToken(int second);
        string CreateRefreshToken();
    }
}