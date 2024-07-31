using BaseProject.Application.Abstractions.Services.Definitions;
using BaseProject.Application.Abstractions.Token;
using BaseProject.Domain.Entities.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Utilities.Core.UtilityApplication.DTOs.Identity;

namespace BaseProject.Infrastructure.Services.Token
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;
        readonly IDepartmentService _departmentService;

        public TokenHandler(IConfiguration configuration, IDepartmentService departmentService)
        {
            _configuration = configuration;
            _departmentService = departmentService;
        }

        public TokenDTO CreateAccessToken(int second, AppUser appUser,string urlPath,string masterCompanyIdFromPlatform)
        {
            TokenDTO tokenDTO = new TokenDTO();

            //Security Key'in simetriğini alıyoruz.
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));

            //Şifrelenmiş kimliği oluşturuyoruz.
            SigningCredentials signingCredentiales = new(securityKey, SecurityAlgorithms.HmacSha256);

            //oluşturulacak token ayarlarını veriyoruz.
            var audiences = _configuration.GetSection("Token:Audience").Get<string[]>();

            List<Claim> audienceClaims = new();
            foreach (var audience in audiences)
            {
                audienceClaims.Add(new Claim("aud", audience));
            }

            var department = appUser.DepartmentId != null ? _departmentService.GetDepartmentById(appUser.DepartmentId.ToString()) : null;

            audienceClaims.Add(new Claim("UrlPath", urlPath));
            audienceClaims.Add(new Claim("MasterCompanyIdFromPlatform", masterCompanyIdFromPlatform));
            audienceClaims.Add(new Claim("Fullname", appUser.FullName));
            audienceClaims.Add(new Claim("CompanyId", appUser.CompanyId.ToString() ?? ""));
            audienceClaims.Add(new Claim("CompanyName", department != null ? department.CompanyName : ""));
            audienceClaims.Add(new Claim("BranchId", appUser.BranchId.ToString() ?? ""));
            audienceClaims.Add(new Claim("BranchName", department != null ? department.BranchName : ""));
            audienceClaims.Add(new Claim("DepartmentId", appUser.DepartmentId.ToString() ?? ""));
            audienceClaims.Add(new Claim("DepartmentName", department != null ? department.Name : ""));

            audienceClaims.Add(new(ClaimTypes.NameIdentifier, appUser.Id));
            audienceClaims.Add(new(ClaimTypes.Name, appUser.UserName));
            audienceClaims.Add(new(ClaimTypes.Email, appUser.Email));

            tokenDTO.ExpiryDate = DateTime.UtcNow.AddSeconds(second);
            JwtSecurityToken securityToken = new(
                issuer: _configuration["Token:Issuer"],
                expires: tokenDTO.ExpiryDate,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentiales,
                claims: audienceClaims
                );

            //Token oluşturucu sınıfından bir örnek alınacak.
            JwtSecurityTokenHandler tokenHandler = new();
            tokenDTO.AccessToken = tokenHandler.WriteToken(securityToken);

            tokenDTO.RefreshToken = CreateRefreshToken();
            return tokenDTO;
        }

        public string CreateRefreshToken()
        {
            byte[] number = new byte[32];
            using RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(number);

            return Convert.ToBase64String(number);
        }
    }
}
