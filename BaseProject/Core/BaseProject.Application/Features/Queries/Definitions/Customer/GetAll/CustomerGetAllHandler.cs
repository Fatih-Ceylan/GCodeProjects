using BaseProject.Application.Repositories.ReadRepository.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Customer.GetAll
{
    public class CustomerGetAllHandler : IRequestHandler<CustomerGetAllRequest, CustomerGetAllResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public CustomerGetAllHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public Task<CustomerGetAllResponse> Handle(CustomerGetAllRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _customerReadRepository.GetAllDeletedStatus(false).Count();
            var customers = _customerReadRepository.GetAllDeletedStatusDescending(false)
                                             .Skip(request.Page * request.Size)
                                             .Take(request.Size).ToList();

            return Task.FromResult(new CustomerGetAllResponse
            {
                TotalCount = totalCount,
                Customers = customers,
            });
        }
    }
}