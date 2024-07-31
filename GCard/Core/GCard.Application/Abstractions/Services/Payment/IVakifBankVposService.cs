using GCard.Application.Features.Commands.Definitions.Payment.VPos;

namespace GCard.Application.Abstractions.Services.Payment
{
    public interface IVakifBankVposService
    {
        Task<CreatePaymentResponse> VerifyGateway(CreatePaymentRequest request);

    }
}
