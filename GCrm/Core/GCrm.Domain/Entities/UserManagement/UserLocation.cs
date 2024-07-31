using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.UserManagement
{
    public  class UserLocation : BaseEntity
    {
        public string  LocationName { get; set; }       
        public Users Users { get; set; }
    }
}
