using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class RecruitmentStepWriteRepository : WriteRepository<BaseProjectDbContext, RecruitmentStep>, IRecruitmentStepWriteRepository
    {
        public RecruitmentStepWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
