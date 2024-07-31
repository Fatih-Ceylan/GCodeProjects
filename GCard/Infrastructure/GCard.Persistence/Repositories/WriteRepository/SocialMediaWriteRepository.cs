using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class SocialMediaWriteRepository : T.WriteRepository<BaseProjectDbContext, SocialMedia>, ISocialMediaWriteRepository
    {
        public SocialMediaWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
