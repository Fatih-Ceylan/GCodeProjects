using BaseProject.Domain.Entities.Definitions;
using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.NLLogistics.Definitions
{
    public class Airline : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int? CountryId { get; set; }

        public Country? Country { get; set; }

    }
}