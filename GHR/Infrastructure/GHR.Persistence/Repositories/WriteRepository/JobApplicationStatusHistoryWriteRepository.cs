using BaseProject.Domain.Entities.GHR.Recruitment.Applications;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class JobApplicationStatusHistoryWriteRepository : WriteRepository<BaseProjectDbContext, JobApplicationStatusHistory>, IJobApplicationStatusHistoryWriteRepository
    {
        public JobApplicationStatusHistoryWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
