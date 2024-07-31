using MediatR;

namespace GCard.Application.Features.Commands.Definitions.PhoneNumber.Delete
{
    public class DeletePhoneNumberRequest : IRequest<DeletePhoneNumberResponse>
    {
        public string Id { get; set; }
    }
}
