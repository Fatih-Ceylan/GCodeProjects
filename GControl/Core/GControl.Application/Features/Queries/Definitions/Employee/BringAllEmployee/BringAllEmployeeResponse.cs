using GControl.Application.VMs.Definitions;

namespace GControl.Application.Features.Queries.Definitions.Employee.BringAllEmployee
{
    public class BringAllEmployeeResponse
    {
        public int TotalCount { get; set; }

        public List<EmployeeVM> Employees { get; set; }
    }
}
