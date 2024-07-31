using MediatR;

namespace GCard.Application.Features.Queries.Definitions.SocialMedia.GetById
{
    public class GetByIdSocialMediaRequest : IRequest<GetByIdSocialMediaResponse>
    {
        public string Id { get; set; }
    }
}
