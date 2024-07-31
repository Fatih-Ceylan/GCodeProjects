using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class CargoWriteRepository : WriteRepository<BaseProjectDbContext, Cargo>, ICargoWriteRepository
    {
        public CargoWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
