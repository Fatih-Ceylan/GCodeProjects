using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Persistence.Contexts;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class RecruitmentProcessStepReadRepository : ReadRepository<BaseProjectDbContext, RecruitmentProcessStep>
    {
        public RecruitmentProcessStepReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
