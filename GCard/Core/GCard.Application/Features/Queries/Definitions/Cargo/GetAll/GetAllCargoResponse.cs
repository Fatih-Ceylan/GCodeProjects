using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.Cargo.GetAll
{
    public class GetAllCargoResponse
    {
        public int TotalCount { get; set; }
        public List<CargoVM> Cargos { get; set; }
    }
}
