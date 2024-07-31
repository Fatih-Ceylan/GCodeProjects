using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Persistence.Contexts;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class RecruitmentStepReadRepository : ReadRepository<BaseProjectDbContext, RecruitmentStep>
    {
        public RecruitmentStepReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
