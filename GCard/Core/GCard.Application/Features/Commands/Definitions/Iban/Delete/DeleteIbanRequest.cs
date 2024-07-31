using MediatR;

namespace GCard.Application.Features.Commands.Definitions.Iban.Delete
{
    public class DeleteIbanRequest : IRequest<DeleteIbanResponse>
    {
        public string Id { get; set; }
    }
}
