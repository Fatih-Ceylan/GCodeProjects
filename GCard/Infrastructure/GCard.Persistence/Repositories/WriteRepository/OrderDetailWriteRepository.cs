using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class OrderDetailWriteRepository : WriteRepository<BaseProjectDbContext, OrderDetail>, IOrderDetailWriteRepository
    {
        public OrderDetailWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
