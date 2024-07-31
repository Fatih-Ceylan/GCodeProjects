using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class LocationWriteRepository : WriteRepository<BaseProjectDbContext, Location>, ILocationWriteRepository
    {
        public LocationWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
