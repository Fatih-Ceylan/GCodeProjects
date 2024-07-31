using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class SocialMediaReadRepository : ReadRepository<BaseProjectDbContext, SocialMedia>, ISocialMediaReadRepository
    {
        public SocialMediaReadRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
