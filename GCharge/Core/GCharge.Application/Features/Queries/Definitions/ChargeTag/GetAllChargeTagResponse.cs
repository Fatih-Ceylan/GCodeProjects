using GCharge.Application.VMs.Definitions.ChargeTag;

namespace GCharge.Application.Features.Queries.Definitions.ChargeTag
{
    public class GetAllChargeTagResponse
    {
        public int TotalCount { get; set; }

        public List<ChargeTagVM> ChargeTags { get; set; }
    }
}
