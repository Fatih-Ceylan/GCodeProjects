using MediatR;

namespace GCard.Application.Features.Commands.Definitions.StaffContact.Delete
{
    public class DeleteStaffContactRequest : IRequest<DeleteStaffContactResponse>
    {
        public string Id { get; set; }
    }
}
