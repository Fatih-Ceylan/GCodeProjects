using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class IbanWriteRepository : T.WriteRepository<BaseProjectDbContext, Iban>, IIbanWriteRepository
    {
        public IbanWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
