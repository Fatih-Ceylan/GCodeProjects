using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Card.GetAll
{
    public class GetAllCardResponse
    {
        public int TotalCount { get; set; }
        public List<CardVM> Cards { get; set; }
    }
}
