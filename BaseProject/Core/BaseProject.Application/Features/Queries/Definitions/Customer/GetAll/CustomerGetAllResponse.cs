namespace BaseProject.Application.Features.Queries.Definitions.Customer.GetAll
{
    public class CustomerGetAllResponse
    {
        public int TotalCount { get; set; }

        public object Customers { get; set; }
    }
}