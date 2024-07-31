using MediatR;

namespace GCard.Application.Features.Queries.Definitions.StaffFile.GetById
{
    public class GetByIdStaffFileRequest : IRequest<GetByIdStaffFileResponse>
    {
        public string Id { get; set; }
    }
}
