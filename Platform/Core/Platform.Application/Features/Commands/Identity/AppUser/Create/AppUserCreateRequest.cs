using MediatR;

namespace Platform.Application.Features.Commands.Identity.AppUser.Create
{
    public class AppUserCreateRequest : IRequest<AppUserCreateREsponse>
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
