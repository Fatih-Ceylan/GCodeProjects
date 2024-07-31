using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.NLLogistics.Definitions
{
    public class Voyage : BaseEntity
    {
        public Guid VesselId { get; set; }

        public string Name { get; set; }

        public Vessel Vessel { get; set; }

    }
}