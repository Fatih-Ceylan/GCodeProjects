using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class SelfServiceReadRepository : ReadRepository<BaseProjectDbContext, SelfService>
    {
        public SelfServiceReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
