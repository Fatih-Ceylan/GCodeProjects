using Utilities.Core.UtilityDomain.Entities.Files;

namespace GCrm.Domain.Entities.ActivityManagement.Files
{
    public class CustomerActivityFile: AppFile
    {
        public ICollection<CustomerActivity> CustomerActivities { get; set; }
    }
}
