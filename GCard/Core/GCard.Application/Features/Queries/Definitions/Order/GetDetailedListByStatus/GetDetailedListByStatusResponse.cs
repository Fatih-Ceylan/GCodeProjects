using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Order.GetDetailedListByStatus
{
    public class GetDetailedListByStatusResponse 
    {
        public List<DetailedOrderListVM> DetailedOrders { get; set; }
    }
}
