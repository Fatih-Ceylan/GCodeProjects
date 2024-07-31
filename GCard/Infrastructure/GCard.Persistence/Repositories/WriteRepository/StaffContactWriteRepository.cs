using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class StaffContactWriteRepository : T.WriteRepository<BaseProjectDbContext, StaffContact>, IStaffContactWriteRepository
    {
        public StaffContactWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
