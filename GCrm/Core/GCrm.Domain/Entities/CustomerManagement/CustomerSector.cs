using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.CustomerManagement
{
    public class CustomerSector : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}