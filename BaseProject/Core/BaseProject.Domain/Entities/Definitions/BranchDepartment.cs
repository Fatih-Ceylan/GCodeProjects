using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.Definitions
{
    public class BranchDepartment: BaseEntity
    {
        public Guid BranchId { get; set; }

        public Guid DepartmentId { get; set; }

        public Branch Branch { get; set; }

        public Department Department { get; set; }
    }
}
