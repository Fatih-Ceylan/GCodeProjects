using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.Payroll.Delete
{
    public class DeletePayrollRequest : IRequest<DeletePayrollResponse>
    {
        public string Id { get; set; }
    }
}
