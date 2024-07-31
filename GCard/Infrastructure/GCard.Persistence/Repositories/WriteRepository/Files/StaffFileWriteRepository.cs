using BaseProject.Domain.Entities.GCard.Definitions.Files;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository.Files
{
    public class StaffFileWriteRepository : WriteRepository<BaseProjectDbContext, StaffFile>, IStaffFileWriteRepository
    {
        public StaffFileWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
