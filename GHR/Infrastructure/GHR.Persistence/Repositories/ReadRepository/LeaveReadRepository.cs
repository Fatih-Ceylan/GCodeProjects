using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class LeaveReadRepository : ReadRepository<BaseProjectDbContext, Leave>, ILeaveReadRepository
    {
        public LeaveReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
