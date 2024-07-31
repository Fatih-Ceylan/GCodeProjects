using BaseProject.Domain.Entities.GHR.Recruitment.Jobs;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class JobAdvertWriteRepository : WriteRepository<BaseProjectDbContext, JobAdvert>, IJobAdvertWriteRepository
    {
        public JobAdvertWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
