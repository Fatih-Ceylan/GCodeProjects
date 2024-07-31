using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class LeaveTypeWriteRepository : WriteRepository<BaseProjectDbContext, LeaveType>, ILeaveTypeWriteRepository
    {
        public LeaveTypeWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
