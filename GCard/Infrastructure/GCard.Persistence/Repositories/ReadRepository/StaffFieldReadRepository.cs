using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class StaffFieldReadRepository : ReadRepository<BaseProjectDbContext, StaffField>, IStaffFieldReadRepository
    {
        public StaffFieldReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
