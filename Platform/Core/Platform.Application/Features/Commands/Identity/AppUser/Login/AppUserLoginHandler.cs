using AutoMapper;
using MediatR;
using Utilities.Core.UtilityApplication.Absractions.Services;
using Utilities.Core.UtilityApplication.DTOs.Identity.Auth.Login;

namespace Platform.Application.Features.Commands.Identity.AppUser.Login
{
    public class AppUserLoginHandler : IRequestHandler<AppUserLoginRequest, AppUserLoginResponse>
    {
        readonly IAuthService _authService;
        readonly IMapper _mapper;

        public AppUserLoginHandler(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        public async Task<AppUserLoginResponse> Handle(AppUserLoginRequest request, CancellationToken cancellationToken)
        {
            var loginRequestDto = _mapper.Map<LoginRequestDTO>(request);
            var loginResponseDto = await _authService.LoginAsync(loginRequestDto);

            return _mapper.Map<AppUserLoginResponse>(loginResponseDto);
        }
    }
}