using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Order.GetDetailedListById
{
    public class GetDetailedListByIdResponse
    {
        public List<DetailedOrderListVM> DetailedOrders { get; set; }
    }
}
