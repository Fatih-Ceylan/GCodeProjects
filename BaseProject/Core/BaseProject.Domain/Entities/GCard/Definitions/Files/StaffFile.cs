using Utilities.Core.UtilityDomain.Entities.Files;

namespace BaseProject.Domain.Entities.GCard.Definitions.Files
{
    public class StaffFile : AppFile
    {
        public ICollection<Staff> Staffs { get; set; }
    }
}
