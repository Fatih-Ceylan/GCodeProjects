using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class PhoneNumberReadRepository : ReadRepository<BaseProjectDbContext, PhoneNumber>, IPhoneNumberReadRepository
    {
        public PhoneNumberReadRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
