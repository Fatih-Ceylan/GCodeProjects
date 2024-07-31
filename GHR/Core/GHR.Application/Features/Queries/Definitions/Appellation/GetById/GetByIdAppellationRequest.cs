using MediatR;

namespace GHR.Application.Features.Queries.Definitions.Appellation.GetById
{
    public class GetByIdAppellationRequest : IRequest<GetByIdAppellationResponse>
    {
        public string Id { get; set; }
    }
}
