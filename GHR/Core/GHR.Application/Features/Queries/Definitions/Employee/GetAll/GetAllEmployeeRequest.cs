using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GHR.Application.Features.Queries.Definitions.Employee.GetAll
{
    public class GetAllEmployeeRequest : Pagination, IRequest<GetAllEmployeeResponse>
    {
    }
}
