using MediatR;

namespace GHR.Application.Features.Commands.Identity.Employee.Login
{
    public class LoginEmployeeRequest : IRequest<LoginEmployeeResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
