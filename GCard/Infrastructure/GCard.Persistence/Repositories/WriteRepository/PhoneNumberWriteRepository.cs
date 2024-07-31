using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class PhoneNumberWriteRepository : T.WriteRepository<BaseProjectDbContext, PhoneNumber>, IPhoneNumberWriteRepository
    {
        public PhoneNumberWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}
