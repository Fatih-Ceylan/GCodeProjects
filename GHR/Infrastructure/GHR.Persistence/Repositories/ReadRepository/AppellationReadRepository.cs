using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class AppellationReadRepository : ReadRepository<BaseProjectDbContext, Appellation>, IAppellationReadRepository
    {
        public AppellationReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
