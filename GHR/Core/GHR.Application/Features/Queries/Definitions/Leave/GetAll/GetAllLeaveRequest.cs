using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GHR.Application.Features.Queries.Definitions.Leave.GetAll
{
    public class GetAllLeaveRequest : Pagination, IRequest<GetAllLeaveResponse>
    {
    }
}
