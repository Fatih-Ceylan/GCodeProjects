using Microsoft.AspNetCore.Identity;
using Utilities.Core.UtilityDomain.Entities.Identity;
using Utilities.Core.UtilityApplication.Absractions.Services;
using Utilities.Core.UtilityApplication.DTOs.Identity.AppUser;

namespace Utilities.Infrastructure.UtilityPersistence.Services
{
    public class AppUserService : IAppUserService
    {
        readonly UserManager<AppUser> _userManager;

        public AppUserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponseDTO> CreateAsync(CreateUserRequestDTO model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                FullName = model.FullName,
                UserName = model.UserName,
                Email = model.Email,
            }, model.Password);

            CreateUserResponseDTO response = new() { Succeed = result.Succeeded };
            if (!result.Succeeded)
            {
                response.Message = "";
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description} \n ";
                }
            }

            return response;
        }

        public async Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate)
        {
            if (user != null)
            {
                user.RefreshToken = refreshToken;
                user.RefreshTokenEndDate = accessTokenDate.AddSeconds(addOnAccessTokenDate);
                await _userManager.UpdateAsync(user);
            }
            else
            {
                throw new Exception(); //NotFoundUserException();
            }
        }
    }
}
