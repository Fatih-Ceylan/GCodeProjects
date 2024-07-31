using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class LeaveTypeReadRepository : ReadRepository<BaseProjectDbContext, LeaveType>, ILeaveTypeReadRepository
    {
        public LeaveTypeReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
