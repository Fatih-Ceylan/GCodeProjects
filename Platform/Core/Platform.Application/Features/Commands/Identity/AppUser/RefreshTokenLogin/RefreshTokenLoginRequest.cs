using MediatR;

namespace Platform.Application.Features.Commands.Identity.AppUser.RefreshTokenLogin
{
    public class RefreshTokenLoginRequest : IRequest<RefreshTokenLoginResponse>
    {
        public string RefreshToken { get; set; }
    }
}
