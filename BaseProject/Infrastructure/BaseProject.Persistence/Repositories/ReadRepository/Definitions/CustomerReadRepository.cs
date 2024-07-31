using BaseProject.Application.Repositories;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Domain.Entities.Definitions;
using BaseProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace BaseProject.Persistence.Repositories.ReadRepositories.Definitions
{
    public class CustomerReadRepository : ReadRepository<BaseProjectDbContext,Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(BaseProjectDbContext context) : base(context)
        {

        }

    }
}