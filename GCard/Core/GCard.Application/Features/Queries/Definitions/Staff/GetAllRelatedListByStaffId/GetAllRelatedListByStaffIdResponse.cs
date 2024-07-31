using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Staff.GetAllRelatedListByStaffId
{
    public class GetAllRelatedListByStaffIdResponse
    {
        public List<GetRelatedListByStaffIdVM> RelatedList { get; set; }

    }
}
