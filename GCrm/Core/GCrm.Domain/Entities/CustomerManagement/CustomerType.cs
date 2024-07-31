using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.CustomerManagement
{
    //müşteri tipi
    public class CustomerType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
