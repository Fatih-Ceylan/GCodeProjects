using Platform.Application.DTOs.Identity.AppUser;

namespace Platform.Application.Abstractions.Services
{
    public interface IBaseProjectService
    {
        Task<string> AddUser(CreateUserRequestDTO user, string accessToken, string routeName);

        Task<string> SoftDeleteAllUsers(string accessToken, string routeName);
    }
}