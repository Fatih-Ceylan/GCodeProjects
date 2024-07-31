using MediatR;

namespace GCard.Application.Features.Commands.Identity.Staff.ForgotPasswordSendMail
{
    public class ForgotPasswordSendMailRequest : IRequest<ForgotPasswordSendMailResponse>
    {
        public string Email { get; set; }
    }
}
