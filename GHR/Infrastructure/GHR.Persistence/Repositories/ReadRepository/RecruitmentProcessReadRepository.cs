using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Persistence.Contexts;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class RecruitmentProcessReadRepository : ReadRepository<BaseProjectDbContext, RecruitmentProcess>
    {
        public RecruitmentProcessReadRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
