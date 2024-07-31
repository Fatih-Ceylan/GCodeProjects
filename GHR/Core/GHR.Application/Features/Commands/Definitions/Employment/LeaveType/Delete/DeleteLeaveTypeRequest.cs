using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.LeaveType.Delete
{
    public class DeleteLeaveTypeRequest : IRequest<DeleteLeaveTypeResponse>
    {
        public string Id { get; set; }
    }
}
