using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.SocialMedia.GetAll
{
    public class GetAllSocialMediaRequest : Pagination, IRequest<GetAllSocialMediaResponse>
    { 
    }
}
