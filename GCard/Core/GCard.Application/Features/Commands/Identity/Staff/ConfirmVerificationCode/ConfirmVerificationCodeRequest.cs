using MediatR;

namespace GCard.Application.Features.Commands.Identity.Staff.ConfirmVerificationCode
{
    public class ConfirmVerificationCodeRequest : IRequest<ConfirmVerificationCodeResponse>
    {
        public string VerificationCode { get; set; }
    }
}
