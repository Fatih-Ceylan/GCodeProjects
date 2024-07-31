using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class EducationInfoReadRepository : ReadRepository<BaseProjectDbContext, EducationInfo>, IEducationInfoReadRepository
    {
        public EducationInfoReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
