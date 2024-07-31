using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Customer.Create
{
    public class CustomerCreateRequest : IRequest<CustomerCreateResponse>
    {
        public string Code { get; set; }

        public string Title { get; set; }
    }
}