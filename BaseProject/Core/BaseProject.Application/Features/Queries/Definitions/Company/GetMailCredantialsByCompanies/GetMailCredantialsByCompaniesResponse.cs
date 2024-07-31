using BaseProject.Application.VMs.Definitions.Company;

namespace BaseProject.Application.Features.Queries.Definitions.Company.GetMailCredantialsByCompanies
{
    public class GetMailCredantialsByCompaniesResponse
    {
        public int TotalCount { get; set; }

        public List<CompanyMailCredantialVM> CompanyMailCredantials { get; set; }
    }
}
