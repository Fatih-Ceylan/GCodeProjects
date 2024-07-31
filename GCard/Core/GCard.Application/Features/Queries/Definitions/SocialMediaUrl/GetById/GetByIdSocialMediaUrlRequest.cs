using MediatR;

namespace GCard.Application.Features.Queries.Definitions.SocialMediaUrl.GetById
{
    public class GetByIdSocialMediaUrlRequest : IRequest<GetByIdSocialMediaUrlResponse>
    {
        public string Id { get; set; }
    }
}
