using MediatR;

namespace GHR.Application.Features.Queries.Definitions.Payroll.GetById
{
    public class GetByIdPayrollRequest : IRequest<GetByIdPayrollResponse>
    {
        public string Id { get; set; }
    }
}
