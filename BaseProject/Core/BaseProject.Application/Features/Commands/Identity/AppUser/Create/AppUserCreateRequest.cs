using MediatR;

namespace BaseProject.Application.Features.Commands.Identity.AppUser.Create
{
    public class AppUserCreateRequest : IRequest<AppUserCreateResponse>
    {

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }
    }
}
