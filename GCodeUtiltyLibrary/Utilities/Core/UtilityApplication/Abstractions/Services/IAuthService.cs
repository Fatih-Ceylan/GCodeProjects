using Utilities.Core.UtilityApplication.DTOs.Identity.Auth.Login;

namespace Utilities.Core.UtilityApplication.Absractions.Services
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> LoginAsync(LoginRequestDTO model);
        Task<LoginResponseDTO> RefreshTokenLoginAsync(string refreshToken);
    }
}