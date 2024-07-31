using BaseProject.Domain.Entities.GHR.Recruitment.Jobs;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class JobAdvertReadRepository : ReadRepository<BaseProjectDbContext, JobAdvert>, IJobAdvertReadRepository
    {
        public JobAdvertReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
