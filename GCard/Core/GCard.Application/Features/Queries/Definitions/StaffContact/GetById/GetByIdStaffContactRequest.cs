using MediatR;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.GetById
{
    public class GetByIdStaffContactRequest : IRequest<GetByIdStaffContactResponse>
    {
        public string Id { get; set; }
    }
}
