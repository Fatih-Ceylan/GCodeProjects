using GCrm.Domain.Entities.Definitions.Customers;
using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.Definitions
{
    public class District : BaseEntity
    {
        public Guid CityId { get; set; }

        public string Name { get; set; }

        public City City { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
