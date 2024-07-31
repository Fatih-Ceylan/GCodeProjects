using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.SocialMediaUrl.GetAll
{
    public class GetAllSocialMediaUrlResponse
    {
        public int TotalCount { get; set; }

        public List<SocialMediaUrlVM> SocialMediaUrls { get; set; }
    }
}
