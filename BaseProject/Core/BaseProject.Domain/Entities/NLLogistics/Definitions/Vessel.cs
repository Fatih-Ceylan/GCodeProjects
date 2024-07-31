using BaseProject.Domain.Entities.Definitions;
using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.NLLogistics.Definitions
{
    public class Vessel : BaseEntity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public string Year { get; set; }

        public string Imo { get; set; }

        public string Link { get; set; }

        public Country Country { get; set; }

    }
}