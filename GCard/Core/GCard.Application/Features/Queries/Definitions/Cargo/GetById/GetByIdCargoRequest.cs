using MediatR;

namespace GCard.Application.Features.Queries.Definitions.Cargo.GetById
{
    public class GetByIdCargoRequest : IRequest<GetByIdCargoResponse>
    {
        public string Id { get; set; }
    }
}
