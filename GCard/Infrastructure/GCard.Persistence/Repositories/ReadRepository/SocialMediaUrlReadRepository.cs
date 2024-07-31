using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class SocialMediaUrlReadRepository : ReadRepository<BaseProjectDbContext, SocialMediaUrl>, ISocialMediaUrlReadRepository
    {
        public SocialMediaUrlReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
