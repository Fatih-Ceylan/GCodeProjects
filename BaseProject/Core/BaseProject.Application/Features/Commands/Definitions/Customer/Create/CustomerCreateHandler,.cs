using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Customer.Create
{
    public class HandlerCreateCustomer : IRequestHandler<CustomerCreateRequest, CustomerCreateResponse>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;

        public HandlerCreateCustomer(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        public async Task<CustomerCreateResponse> Handle(CustomerCreateRequest request, CancellationToken cancellationToken)
        {
            await _customerWriteRepository.AddAsync(new()
            {
                Id = new Guid(),
                Code = request.Code,
                Title = request.Title,
            });
            await _customerWriteRepository.SaveAsync();

            return new();
        }
    }
}