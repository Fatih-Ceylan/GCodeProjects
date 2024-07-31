using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class FieldWriteRepository : T.WriteRepository<BaseProjectDbContext, Field>, IFieldWriteRepository
    {
        public FieldWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
