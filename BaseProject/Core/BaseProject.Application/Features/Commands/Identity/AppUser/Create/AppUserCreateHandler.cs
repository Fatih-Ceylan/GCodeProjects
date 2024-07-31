using MediatR;
using AutoMapper;
using Utilities.Core.UtilityApplication.Absractions.Services;
using Utilities.Core.UtilityApplication.DTOs.Identity.AppUser;

namespace BaseProject.Application.Features.Commands.Identity.AppUser.Create
{
    public class AppUserCreateHandler : IRequestHandler<AppUserCreateRequest, AppUserCreateResponse>
    {
        IAppUserService _appUserService;
        IMapper _mapper;

        public AppUserCreateHandler(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public async Task<AppUserCreateResponse> Handle(AppUserCreateRequest request, CancellationToken cancellationToken)
        { var appUserRequestDto = _mapper.Map<CreateUserRequestDTO>(request);

            var appUserResponseDto = await _appUserService.CreateAsync(appUserRequestDto);

            return _mapper.Map<AppUserCreateResponse>(appUserResponseDto);
           
        }
    }
}