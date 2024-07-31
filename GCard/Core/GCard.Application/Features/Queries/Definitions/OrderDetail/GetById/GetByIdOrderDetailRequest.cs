using MediatR;

namespace GCard.Application.Features.Queries.Definitions.OrderDetail.GetById
{
    public class GetByIdOrderDetailRequest : IRequest<GetByIdOrderDetailResponse>
    {
        public string Id { get; set; }
    }
}
