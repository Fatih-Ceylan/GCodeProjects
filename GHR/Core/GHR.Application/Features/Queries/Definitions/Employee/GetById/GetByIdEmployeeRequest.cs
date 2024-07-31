using MediatR;

namespace GHR.Application.Features.Queries.Definitions.Employee.GetById
{
    public class GetByIdEmployeeRequest : IRequest<GetByIdEmployeeResponse>
    {
        public string Id { get; set; }
    }
}
