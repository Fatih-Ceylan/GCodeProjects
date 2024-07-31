using BaseProject.Domain.Entities.GCard.Definitions.Files;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository.Files
{
    public class StaffFileReadRepository : ReadRepository<BaseProjectDbContext, StaffFile>, IStaffFileReadRepository
    {
        public StaffFileReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
