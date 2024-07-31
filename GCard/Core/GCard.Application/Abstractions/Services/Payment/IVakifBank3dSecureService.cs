using GCard.Application.Features.Commands.Definitions.Payment._3DSecure;

namespace GCard.Application.Abstractions.Services.Payment
{
    public interface IVakifBank3dSecureService
    {
        Task<Create3dSecureResponse> ThreeDGatewayRequest(Create3dSecureRequest request);
    }
}
