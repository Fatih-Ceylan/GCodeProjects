using MediatR;
using AutoMapper;
using BaseProject.Application.Abstractions.Platform;
using Utilities.Core.UtilityApplication.Absractions.Services;
using Utilities.Core.UtilityApplication.DTOs.Identity.Auth.Login;

namespace BaseProject.Application.Features.Commands.Identity.AppUser.Login
{
    public class AppUserLoginHandler : IRequestHandler<AppUserLoginRequest, AppUserLoginResponse>
    {
        readonly IAuthService _authService;
        readonly IMapper _mapper;
        readonly IPlatformService _platformService;

        public AppUserLoginHandler(IAuthService authService, IMapper mapper, IPlatformService platformService)
        {
            _authService = authService;
            _mapper = mapper;
            _platformService = platformService;
        }

        public async Task<AppUserLoginResponse> Handle(AppUserLoginRequest request, CancellationToken cancellationToken)
        {
            var baseDbName = await _platformService.GetDbName(request.MainCompanyId);

            var loginRequestDto = _mapper.Map<LoginRequestDTO>(request);

            var loginResponseDto = await _authService.LoginAsync(loginRequestDto);
            loginResponseDto.BaseDbName = baseDbName;

            return _mapper.Map<AppUserLoginResponse>(loginResponseDto);
        }
    }
}