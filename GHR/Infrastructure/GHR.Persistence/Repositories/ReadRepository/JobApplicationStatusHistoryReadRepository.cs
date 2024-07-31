using BaseProject.Domain.Entities.GHR.Recruitment.Applications;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class JobApplicationStatusHistoryReadRepository : ReadRepository<BaseProjectDbContext, JobApplicationStatusHistory>, IJobApplicationStatusHistoryReadRepository
    {
        public JobApplicationStatusHistoryReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
