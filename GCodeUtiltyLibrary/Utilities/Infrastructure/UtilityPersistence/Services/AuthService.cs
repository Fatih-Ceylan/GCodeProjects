using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Utilities.Core.UtilityDomain.Entities.Identity;
using Utilities.Core.UtilityApplication.Absractions.Services;
using Utilities.Core.UtilityApplication.Absractions.Token;
using Utilities.Core.UtilityApplication.DTOs.Identity;
using Utilities.Core.UtilityApplication.DTOs.Identity.Auth.Login;
using Utilities.Core.UtilityApplication.Exceptions;

namespace Utilities.Infrastructure.UtilityPersistence.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;
        readonly IAppUserService _appUserService;
        readonly IConfiguration _config;

        public AuthService(ITokenHandler tokenHandler, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IAppUserService appUserService, IConfiguration config)
        {
            _tokenHandler = tokenHandler;
            _signInManager = signInManager;
            _userManager = userManager;
            _appUserService = appUserService;
            _config = config;
        }

        public async Task<LoginResponseDTO> LoginAsync(LoginRequestDTO model)
        {
            AppUser appUser = await _userManager.FindByNameAsync(model.UserNameOrEmail);
            if (appUser == null)
            {
                await _userManager.FindByEmailAsync(model.UserNameOrEmail);
            }
            if (appUser == null)
            {
                throw new Exception(); //NotFoundUserException();
            }
            //TODO: şifre kilitleme canlıya alınırken açılacak

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, model.Password, false);
            if (result.Succeeded) // Authentication başarılı!
            {
                TokenDTO token = _tokenHandler.CreateAccessToken(Convert.ToInt32(_config["TokenLifeTime:AccessTokenLifeTime"]));
                await _appUserService.UpdateRefreshTokenAsync(token.RefreshToken, appUser, token.ExpiryDate, Convert.ToInt32(_config["TokenLifeTime:AddToAccessTokenEndDate"]));

                return new()
                {
                    Token = token
                };
            }
            else
            {
                throw new Exception(); //AuthenticationErrorException();
            }
        }

        public async Task<LoginResponseDTO> RefreshTokenLoginAsync(string refreshToken)
        {
            AppUser? appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
            if (appUser != null && appUser?.RefreshTokenEndDate > DateTime.UtcNow)
            {
                TokenDTO tokenDTO = _tokenHandler.CreateAccessToken(Convert.ToInt32(_config["TokenLifeTime:AccessTokenLifeTime"]));
                await _appUserService.UpdateRefreshTokenAsync(refreshToken, appUser, tokenDTO.ExpiryDate, Convert.ToInt32(_config["TokenLifeTime:AddToAccessTokenEndDate"]));
                
                return new()
                {
                    Token = tokenDTO
                };
            }
            else if (appUser == null)
            {
                throw new Exception(); //NotFoundUserException();
            }
            else
                throw new TokenExpiryDateException();
        }
    }
}