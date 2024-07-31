using GHR.Application.VMs.Definitions;

namespace GHR.Application.Features.Queries.Definitions.Payroll.GetAll
{
    public class GetAllPayrollResponse
    {
        public int TotalCount { get; set; }

        public List<PayrollVM> PayrollVMs { get; set; }
    }
}
