using BaseProject.Application.Repositories;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using BaseProject.Domain.Entities.Definitions;
using BaseProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace BaseProject.Persistence.Repositories.WriteRepositories.Definitions
{
    public class CustomerWriteRepository : WriteRepository<BaseProjectDbContext,Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
