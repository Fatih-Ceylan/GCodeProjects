using MediatR;

namespace GCard.Application.Features.Commands.Definitions.OrderDetail.Delete
{
    public class DeleteOrderDetailRequest : IRequest<DeleteOrderDetailResponse>
    {
        public string Id { get; set; }
    }
}
