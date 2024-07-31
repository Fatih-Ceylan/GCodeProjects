using GHR.Application.VMs.Definitions;

namespace GHR.Application.Features.Queries.Definitions.Employee.GetAll
{
    public class GetAllEmployeeResponse
    {
        public int TotalCount { get; set; }

        public List<EmployeeVM> Employees { get; set; }
    }
}
