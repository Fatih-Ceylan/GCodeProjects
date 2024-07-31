using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.CustomerManagement
{
    //Müşteri Türü
    public class CustomerKind : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}