using MediatR;

namespace GCard.Application.Features.Queries.Definitions.OrderDetail.GetListByOrderId
{
    public class GetListByOrderIdRequest : IRequest<GetListByOrderIdResponse>
    {
        public string Id { get; set; }
    }
}
