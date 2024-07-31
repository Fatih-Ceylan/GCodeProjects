using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Customer.GetAll
{
    public class CustomerGetAllRequest : IRequest<CustomerGetAllResponse>
    {
        public int Page { get; set; } = 0;

        public int Size { get; set; } = 5;
    }
}