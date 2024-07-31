using BaseProject.Domain.Entities.GCard.Definitions;
using Utilities.Core.UtilityApplication.Interfaces;

namespace GCard.Application.Repositories.ReadRepository
{
    public interface IPasswordRemakeReadRepository : IReadRepository<PasswordRemake>
    {
        Task<PasswordRemake> GetByTokenAsync(string token, bool tracking = true);
        Task<PasswordRemake> GetByEmailAsync(string email, bool tracking = true);
    }
}
