using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.Definitions
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

    }
}
