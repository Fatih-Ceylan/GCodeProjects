using BaseProject.Application.Abstractions.Services.Identity;
using BaseProject.Application.DTOs.Identity.AppUser;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.VMs.Definitions;
using BaseProject.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Utilities.Core.UtilityApplication.Exceptions;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace BaseProject.Persistence.Services.Identity
{
    public class AppUserService : IAppUserService
    {
        readonly UserManager<AppUser> _userManager;
        readonly IDepartmentReadRepository _departmentReadRepository;

        public AppUserService(UserManager<AppUser> userManager, IDepartmentReadRepository departmentReadRepository)
        {
            _userManager = userManager;
            _departmentReadRepository = departmentReadRepository;
        }

        public async Task<CreateUserResponseDTO> CreateAsync(CreateUserRequestDTO request)
        {
            var id = Guid.NewGuid().ToString();
            
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = id,
                ProfileImagePath = request.ProfileImagePath,
                FullName = request.FullName,
                UserName = request.UserName,
                Email = request.Email,
                CompanyId = Guid.Parse(request.CompanyId),
                BranchId = Guid.Parse(request.BranchId),
                DepartmentId = Guid.Parse(request.DepartmentId),
            }, request.Password);

            CreateUserResponseDTO response = new() { Succeed = result.Succeeded };
            if (!result.Succeeded)
            {
                response.Message = string.Empty;
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description} \n ";
                }
            }
            else
            {
                response.Id = id;
                response.ProfileImagePath = request.ProfileImagePath;
                response.FullName = request.FullName;
                response.UserName = request.UserName;
                response.Email = request.Email;
                response.CompanyId = request.CompanyId;
                response.BranchId = request.BranchId;
                response.DepartmentId = request.DepartmentId;
                response.Message = "User Created Successfully";
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
                throw new NotFoundUserEcxeption();
            }
        }

        public async Task<UpdateUserResponseDTO> UpdateAsync(UpdateUserRequestDTO request)
        {
            var user = await _userManager.FindByIdAsync(request.Id);
            if (user != null)
            {
                user.ProfileImagePath = request.ProfileImagePath != null ? request.ProfileImagePath : user.ProfileImagePath ;
                user.FullName = request.FullName;
                user.UserName = request.UserName;
                user.Email = request.Email;
                user.CompanyId = Guid.Parse(request.CompanyId);
                user.BranchId = Guid.Parse(request.BranchId);
                user.DepartmentId = Guid.Parse(request.DepartmentId);

                IdentityResult result = await _userManager.UpdateAsync(user);

                var response = SetUpdateResponse(result, "Updated");
                if (result.Succeeded)
                {
                    response.ProfileImagePath = request.ProfileImagePath;
                    response.FullName = request.FullName;
                    response.UserName = request.UserName;
                    response.Email = request.Email;
                    response.CompanyId = request.CompanyId;
                    response.BranchId = request.BranchId;
                    response.DepartmentId = request.DepartmentId;
                }

                return response;
            }
            else
            {
                throw new NotFoundUserEcxeption();
            }
        }

        public async Task<DeleteUserResponseDTO> SoftDelete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.IsDeleted = true;
                IdentityResult result = await _userManager.UpdateAsync(user);

                var updateResponse = SetUpdateResponse(result, "Deleted");

                return new()
                {
                    Succeed = updateResponse.Succeed,
                    Message = updateResponse.Message,
                };
            }
            else
            {
                throw new NotFoundUserEcxeption();
            }
        }

        public async Task<UserDTO> GetByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            DepartmentVM department = null;

            if (user != null && user.DepartmentId != null)
            {
                department = _departmentReadRepository.GetWhere(d => d.Id == user.DepartmentId)
                                                          .Select(d => new DepartmentVM
                                                          {
                                                              CompanyName = d.Branch.Company.Name,
                                                              BranchName = d.Branch.Name,
                                                              Name = d.Name
                                                          })
                                                          .FirstOrDefault();
            }

            if (user != null)
            { 
                return new()
                {
                    Id = user.Id,
                    ProfileImagePath = user.ProfileImagePath,
                    FullName = user.FullName,
                    UserName = user.UserName,
                    Email = user.Email,
                    CompanyId = user.CompanyId.ToString(),
                    CompanyName = department != null ? department.CompanyName : null,
                    BranchId = user.BranchId.ToString(),
                    BranchName = department != null ? department.BranchName : null,
                    DepartmentId = user.DepartmentId.ToString(),
                    DepartmentName = department != null ? department.Name : null
                };
            }
            else
            {
                throw new NotFoundUserEcxeption();
            }
        }

        public UserListDTO GetAllDeletedStatus(Pagination paginationRequest)
        {
            var query = _userManager.Users
                        .Where(u => u.IsDeleted == paginationRequest.IsDeleted);

            var users = paginationRequest.DoPagination ? query.Skip(paginationRequest.Page * paginationRequest.Size)
                                                       .Take(paginationRequest.Size)
                                                       .ToList()
                                                : query.ToList();

            var departments = _departmentReadRepository.GetAllDeletedStatus(false)
                                                      .Select(d => new DepartmentVM
                                                      {
                                                          Id = d.Id.ToString(),
                                                          CompanyName = d.Branch.Company.Name,
                                                          BranchName = d.Branch.Name,
                                                          Name = d.Name
                                                      }).ToList();
            
            var result = (from u in users
                          select new UserDTO
                          {
                              Id = u.Id,
                              ProfileImagePath = u.ProfileImagePath,
                              FullName = u.FullName,
                              UserName = u.UserName,
                              Email = u.Email,
                              CompanyId = u.CompanyId.ToString(),
                              CompanyName = u.DepartmentId != null ? departments.Where(d => d.Id == u.DepartmentId.ToString().ToUpper()).Select(d => d.CompanyName).FirstOrDefault() : null,
                              BranchId = u.BranchId.ToString(),
                              BranchName = u.DepartmentId != null ? departments.Where(d => d.Id == u.DepartmentId.ToString().ToUpper()).Select(d => d.BranchName).FirstOrDefault() : null,
                              DepartmentId = u.DepartmentId.ToString(),
                              DepartmentName = u.DepartmentId != null ? departments.Where(d => d.Id == u.DepartmentId.ToString().ToUpper()).Select(d => d.Name).FirstOrDefault() : null,
                          }).ToList();

            return new()
            {
                TotalCount = query.Count(),
                AppUsers = result
            };
        }

        private UpdateUserResponseDTO SetUpdateResponse(IdentityResult result, string setType)
        {
            UpdateUserResponseDTO response = new() { Succeed = result.Succeeded };
            if (!result.Succeeded)
            {
                response.Message = string.Empty;
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description} \n ";
                }
            }
            else
            {
                response.Message = $"User {setType} Successfully";
            }

            return response;
        }

        public async Task UpdatePasswordAsync(string userId, string resetToken, string newPassword)
        {
            AppUser appUser = await _userManager.FindByIdAsync(userId);
            if (appUser != null)
            {
                byte[] tokenBytes = WebEncoders.Base64UrlDecode(resetToken);
                resetToken = Encoding.UTF8.GetString(tokenBytes);
                IdentityResult result = await _userManager.ResetPasswordAsync(appUser, resetToken, newPassword);
                if (result.Succeeded)
                    await _userManager.UpdateSecurityStampAsync(appUser);
                else
                    throw new Exception("Password change failed!");
            }
            else
                throw new NotFoundUserEcxeption();
        }
    }
}