using GHR.Application.VMs.Definitions;

namespace GHR.Application.Features.Queries.Definitions.Leave.GetAll
{
    public class GetAllLeaveResponse
    {
        public int TotalCount { get; set; }

        public List<LeaveVM> LeaveVMs { get; set; }
    }
}
