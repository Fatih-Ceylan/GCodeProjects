using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class StaffContactReadRepository : ReadRepository<BaseProjectDbContext, StaffContact>, IStaffContactReadRepository
    {
        public StaffContactReadRepository(BaseProjectDbContext context) : base(context)
        {
        } 
    }
}
