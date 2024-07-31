using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class AddressWriteRepository : WriteRepository<BaseProjectDbContext, Address>, IAddressWriteRepository
    {
        public AddressWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
