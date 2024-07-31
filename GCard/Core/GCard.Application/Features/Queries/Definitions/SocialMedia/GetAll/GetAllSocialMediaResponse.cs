using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.SocialMedia.GetAll
{
    public class GetAllSocialMediaResponse
    {
        public int TotalCount { get; set; }

        public List<SocialMediaVM> SocialMedias { get; set; }
    }
}
