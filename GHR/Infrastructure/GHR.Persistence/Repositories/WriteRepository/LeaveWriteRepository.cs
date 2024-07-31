using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class LeaveWriteRepository : WriteRepository<BaseProjectDbContext, Leave>, ILeaveWriteRepository
    {
        public LeaveWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
