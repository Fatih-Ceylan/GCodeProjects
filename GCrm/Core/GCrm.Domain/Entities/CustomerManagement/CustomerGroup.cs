using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.CustomerManagement
{
    public  class CustomerGroup :BaseEntity
    {
        public string CustomerGroupName { get; set; }
        public string CustomerGroupType { get; set; }
        public Customer Customer { get; set; }
    }
}
