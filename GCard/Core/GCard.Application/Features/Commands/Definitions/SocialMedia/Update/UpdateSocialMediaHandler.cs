using AutoMapper;
using GCard.Application.Repositories.ReadRepository;
using GCard.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.GCard.Definitions;

namespace GCard.Application.Features.Commands.Definitions.SocialMedia.Update
{
    public class UpdateSocialMediaHandler : IRequestHandler<UpdateSocialMediaRequest, UpdateSocialMediaResponse>
    {
        readonly ISocialMediaWriteRepository _socialMediaWriteRepository;
        readonly ISocialMediaReadRepository _socialMediaReadRepository;
        readonly IMapper _mapper;

        public UpdateSocialMediaHandler(ISocialMediaWriteRepository socialMediaWriteRepository, ISocialMediaReadRepository socialMediaReadRepository, IMapper mapper)
        {
            _socialMediaWriteRepository = socialMediaWriteRepository;
            _socialMediaReadRepository = socialMediaReadRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSocialMediaResponse> Handle(UpdateSocialMediaRequest request, CancellationToken cancellationToken)
        {
            T.SocialMedia socialMedia = await _socialMediaReadRepository.GetByIdAsync(request.Id);
            socialMedia = _mapper.Map(request, socialMedia);
            await _socialMediaWriteRepository.SaveAsync();

            var updatedResponse = _mapper.Map<UpdateSocialMediaResponse>(socialMedia);
            updatedResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();

            return updatedResponse;
        }
    }
}
