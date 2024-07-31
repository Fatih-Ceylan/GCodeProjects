using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Order.GetStaffAndQrListByOrderId
{
    public class GetStaffAndQrListByOrderIdResponse
    {
        public List<StaffAndQrListVM> StaffAndQrs { get; set; } 
    }
}
