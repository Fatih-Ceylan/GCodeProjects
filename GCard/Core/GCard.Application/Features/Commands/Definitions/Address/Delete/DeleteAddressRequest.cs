using MediatR;

namespace GCard.Application.Features.Commands.Definitions.Address.Delete
{
    public class DeleteAddressRequest : IRequest<DeleteAddressResponse>
    {
        public string Id { get; set; }
    }
}
