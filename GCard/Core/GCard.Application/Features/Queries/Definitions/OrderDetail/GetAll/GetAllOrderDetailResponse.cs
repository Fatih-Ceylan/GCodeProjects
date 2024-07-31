using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.OrderDetail.GetAll
{
    public class GetAllOrderDetailResponse
    {
        public int TotalCount { get; set; }

        public List<OrderDetailVM> OrderDetails { get; set; }
    }
}
