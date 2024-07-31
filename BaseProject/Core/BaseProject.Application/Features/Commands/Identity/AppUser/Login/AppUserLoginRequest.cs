using MediatR;

namespace BaseProject.Application.Features.Commands.Identity.AppUser.Login
{
    public class AppUserLoginRequest: IRequest<AppUserLoginResponse>
    {

        public string UserNameOrEmail { get; set; }

        public string Password { get; set; }

        public string MainCompanyId { get; set; }
    }
}