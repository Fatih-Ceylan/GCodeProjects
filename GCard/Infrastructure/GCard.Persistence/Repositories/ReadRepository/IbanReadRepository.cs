using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class IbanReadRepository : ReadRepository<BaseProjectDbContext, Iban>, IIbanReadRepository
    {
        public IbanReadRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
