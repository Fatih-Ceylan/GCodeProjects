using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.Definitions
{
    public class Customer: BaseEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
    }
}
