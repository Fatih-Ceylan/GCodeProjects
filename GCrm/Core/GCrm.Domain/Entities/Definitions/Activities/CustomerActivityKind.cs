using GCrm.Domain.Entities.ActivityManagement;
using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.Definitions.Activities
{
    public class CustomerActivityKind : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<CustomerActivity> CustomerActivities { get; set; }
    }
}
