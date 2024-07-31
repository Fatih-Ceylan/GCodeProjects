using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.GetContactListByStaffId
{
    public class GetContactListByStaffIdResponse
    {
        public int TotalCount { get; set; }
        public List<StaffContactVM> Contacts { get; set; }
    }
}
