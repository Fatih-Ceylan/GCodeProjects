using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class PayrollWriteRepository : WriteRepository<BaseProjectDbContext, Payroll>, IPayrollWriteRepository
    {
        public PayrollWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
