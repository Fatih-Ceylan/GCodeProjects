using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.Leave.Delete
{
    public class DeleteLeaveRequest : IRequest<DeleteLeaveResponse>
    {
        public string Id { get; set; }
    }
}
