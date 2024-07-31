namespace BaseProject.Application.Features.Queries.Definitions.Company.GetAll
{
    public class CompanyGetAllResponse
    {
        public int TotalCount { get; set; }

        public object Companies { get; set; }
    }
}