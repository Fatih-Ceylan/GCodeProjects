using BaseProject.Application.Repositories.ReadRepository.Definitions;
using MediatR;
using T = BaseProject.Domain.Entities.Definitions;

namespace BaseProject.Application.Features.Queries.Definitions.Customer.GetById
{
    public class CustomerGetByIdHandler : IRequestHandler<CustomerGetByIdRequest, CustomerGetByIdResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public CustomerGetByIdHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<CustomerGetByIdResponse> Handle(CustomerGetByIdRequest request, CancellationToken cancellationToken)
        {
            T.Customer customer = await _customerReadRepository.GetByIdAsync(request.Id, false);

            return new CustomerGetByIdResponse
            {
                Id = customer.Id.ToString(),
                Code = customer.Code,
                Title = customer.Title
            };
        }
    }
}