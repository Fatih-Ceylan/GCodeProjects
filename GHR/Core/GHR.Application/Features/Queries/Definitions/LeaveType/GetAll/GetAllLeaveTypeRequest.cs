using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GHR.Application.Features.Queries.Definitions.LeaveType.GetAll
{
    public class GetAllLeaveTypeRequest : Pagination, IRequest<GetAllLeaveTypeResponse>
    {
    }
}
