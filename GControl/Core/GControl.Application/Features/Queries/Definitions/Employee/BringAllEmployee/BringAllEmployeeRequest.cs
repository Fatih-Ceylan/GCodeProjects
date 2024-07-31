using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GControl.Application.Features.Queries.Definitions.Employee.BringAllEmployee
{
    public class BringAllEmployeeRequest : Pagination, IRequest<BringAllEmployeeResponse>
    {
    }
}
