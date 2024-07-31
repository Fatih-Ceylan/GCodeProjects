using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Staff.GetAll
{
    public class GetAllStaffResponse
    {
        public int TotalCount { get; set; }

        public List<StaffVM> Staffs { get; set; }
    }
}
