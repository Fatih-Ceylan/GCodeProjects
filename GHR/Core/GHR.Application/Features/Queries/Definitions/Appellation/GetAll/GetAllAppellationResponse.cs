using GHR.Application.VMs.Definitions;

namespace GHR.Application.Features.Queries.Definitions.Appellation.GetAll
{
    public class GetAllAppellationResponse
    {
        public int TotalCount { get; set; }

        public List<AppellationVM> Appellations { get; set; }
    }
}
