using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class EmployeeReadRepository : ReadRepository<BaseProjectDbContext, Employee>, IEmployeeReadRepository
    {
        public EmployeeReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
