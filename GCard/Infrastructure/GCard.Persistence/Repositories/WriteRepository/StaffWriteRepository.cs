using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class StaffWriteRepository : T.WriteRepository<BaseProjectDbContext, Staff>, IStaffWriteRepository
    {
        public StaffWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
