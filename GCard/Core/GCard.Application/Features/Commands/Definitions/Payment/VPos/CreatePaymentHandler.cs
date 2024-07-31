using GCard.Application.Abstractions.Services.Payment;
using MediatR;

namespace GCard.Application.Features.Commands.Definitions.Payment.VPos
{
    public class CreatePaymentHandler : IRequestHandler<CreatePaymentRequest, CreatePaymentResponse>
    {

        readonly IVakifBankVposService _vakifBankVposService;

        public CreatePaymentHandler(IVakifBankVposService vakifBankVposService)
        {
            _vakifBankVposService = vakifBankVposService;
        }

        public async Task<CreatePaymentResponse> Handle(CreatePaymentRequest request, CancellationToken cancellationToken)
        {

            var response = _vakifBankVposService.VerifyGateway(request).Result;

            return response;
        }
    }
}
