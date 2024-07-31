using MediatR;

namespace GCard.Application.Features.Commands.Definitions.SocialMedia.Create
{
    public class CreateSocialMediaRequest : IRequest<CreateSocialMediaResponse>
    {
        public string? Name { get; set; }
    }
}
