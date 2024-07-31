using BaseProject.Domain.Entities.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Core.UtilityApplication.Interfaces;

namespace BaseProject.Application.Repositories.WriteRepository.Definitions
{
    public interface ICustomerWriteRepository : IWriteRepository<Customer>
    {
    }
}
