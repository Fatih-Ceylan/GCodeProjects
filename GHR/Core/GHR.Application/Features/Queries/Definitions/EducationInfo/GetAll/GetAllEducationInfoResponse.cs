using GHR.Application.VMs.Definitions;

namespace GHR.Application.Features.Queries.Definitions.EducationInfo.GetAll
{
    public class GetAllEducationInfoResponse
    {
        public int TotalCount { get; set; }

        public List<EducationInfoVM> EducationInfos { get; set; }
    }
}
