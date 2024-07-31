using GCharge.Application.VMs.Definitions.ChargePoint;

namespace GCharge.Application.Features.Queries.Definitions.ChargePoint
{
    public class GetAllChargePointResponse
    {
        public int TotalCount { get; set; }

        public List<ChargePointVM> ChargePoints { get; set; }
    }
}