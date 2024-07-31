using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.GetAll
{
    public class GetAllStaffContactResponse
    {
        public int TotalCount { get; set; }

        public List<StaffContactVM> StaffContacts { get; set; }
    }
}
