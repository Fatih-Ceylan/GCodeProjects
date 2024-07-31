using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.StaffField.GetAllFieldByStaffId
{
    public class GetAllFieldByStaffIdStaffFieldResponse
    {
        public int TotalCount { get; set; }
        public List<StaffFieldVM> StaffFields { get; set; }
    }
}
