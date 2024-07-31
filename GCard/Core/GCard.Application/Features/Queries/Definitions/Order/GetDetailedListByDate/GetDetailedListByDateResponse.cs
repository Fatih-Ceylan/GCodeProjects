using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Order.GetDetailedListByDate
{
    public class GetDetailedListByDateResponse
    {
        public List<DetailedOrderListVM> DetailedOrders { get; set; }
    }
}
