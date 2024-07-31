using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.Definitions
{
    public class City : BaseEntity
    {
        public Guid CountryId { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }

        public ICollection<District> Districts { get; set; }

    }
}