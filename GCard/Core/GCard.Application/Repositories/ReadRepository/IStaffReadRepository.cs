using BaseProject.Domain.Entities.GCard.Definitions;
using Utilities.Core.UtilityApplication.Interfaces;

namespace GCard.Application.Repositories.ReadRepository
{
    public interface IStaffReadRepository : IReadRepository<Staff>
    {
        Task<Staff> GetByEmailAsync(string email, bool tracking = true);
        Task<Staff> GetByUserNameAsync(string userName, bool tracking = true);
    }
}
