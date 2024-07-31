using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class StaffFieldWriteRepository : T.WriteRepository<BaseProjectDbContext, StaffField>, IStaffFieldWriteRepository
    {
        public StaffFieldWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
