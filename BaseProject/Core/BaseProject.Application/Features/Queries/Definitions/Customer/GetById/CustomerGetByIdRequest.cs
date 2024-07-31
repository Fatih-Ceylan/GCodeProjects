using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Customer.GetById
{
    public class CustomerGetByIdRequest : IRequest<CustomerGetByIdResponse>
    {
        public string Id { get; set; }
    }
}
