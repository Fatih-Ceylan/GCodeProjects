using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.StaffField.GetAll
{
    public class GetAllStaffFieldResponse
    {
        public int TotalCount { get; set; }

        public List<StaffFieldVM> StaffFields { get; set; }
    }
}
