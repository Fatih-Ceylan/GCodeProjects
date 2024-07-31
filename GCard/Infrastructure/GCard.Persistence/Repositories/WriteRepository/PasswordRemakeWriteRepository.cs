using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class PasswordRemakeWriteRepository : T.WriteRepository<BaseProjectDbContext, PasswordRemake>, IPasswordRemakeWriteRepository
    {
        public PasswordRemakeWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
