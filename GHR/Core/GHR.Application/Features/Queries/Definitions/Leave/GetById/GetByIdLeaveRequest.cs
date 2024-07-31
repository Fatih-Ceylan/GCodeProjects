using MediatR;

namespace GHR.Application.Features.Queries.Definitions.Leave.GetById
{
    public class GetByIdLeaveRequest : IRequest<GetByIdLeaveResponse>
    {
        public string Id { get; set; }
    }
}
