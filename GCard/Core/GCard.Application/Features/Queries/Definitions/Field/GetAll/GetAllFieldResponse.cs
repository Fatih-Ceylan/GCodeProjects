using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Field.GetAll
{
    public class GetAllFieldResponse
    {
        public int TotalCount { get; set; }

        public List<FieldVM> Fields { get; set; }
    }
}
