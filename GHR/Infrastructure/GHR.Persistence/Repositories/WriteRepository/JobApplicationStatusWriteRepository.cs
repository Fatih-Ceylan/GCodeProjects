using BaseProject.Domain.Entities.GHR.Recruitment.Applications;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class JobApplicationStatusWriteRepository : WriteRepository<BaseProjectDbContext, JobApplicationStatus>, IJobApplicationStatusWriteRepository
    {
        public JobApplicationStatusWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
