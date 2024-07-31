using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Domain.Entities.Definitions;
using BaseProject.Persistence.Contexts;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace BaseProject.Persistence.Repositories.ReadRepository.Definitions
{
    public class MailCredantialReadRepository : ReadRepository<BaseProjectDbContext, MailCredantial>, IMailCredantialReadRepository
    {
        public MailCredantialReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
