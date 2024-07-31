using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.CustomerManagement
{
    public class CustomerCategory : BaseEntity
    {
        public string Name { get; set; }

        public string? MainCategoryId { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}