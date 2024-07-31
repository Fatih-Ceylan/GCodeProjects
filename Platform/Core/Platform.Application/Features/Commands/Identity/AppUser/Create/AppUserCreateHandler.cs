using MediatR;
using AutoMapper;
using Utilities.Core.UtilityApplication.Absractions.Services;
using Utilities.Core.UtilityApplication.DTOs.Identity.AppUser;

namespace Platform.Application.Features.Commands.Identity.AppUser.Create
{
    public class AppUserCreateHandler : IRequestHandler<AppUserCreateRequest, AppUserCreateREsponse>
    {
        readonly IAppUserService _appUserService;
        readonly IMapper _mapper;

        public AppUserCreateHandler(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public async Task<AppUserCreateREsponse> Handle(AppUserCreateRequest request, CancellationToken cancellationToken)
        {
            var appUserRequestDto = _mapper.Map<CreateUserRequestDTO>(request);
            var appUserResponseDto = await _appUserService.CreateAsync(appUserRequestDto);

            return _mapper.Map<AppUserCreateREsponse>(appUserResponseDto);
        }
    }
}