using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.Employee.Delete
{
    public class DeleteEmployeeRequest : IRequest<DeleteEmployeeResponse>
    {
        public string Id { get; set; }
    }
}
