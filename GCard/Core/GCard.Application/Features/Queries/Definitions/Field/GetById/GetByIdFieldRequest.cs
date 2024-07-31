using MediatR;

namespace GCard.Application.Features.Queries.Definitions.Field.GetById
{
    public class GetByIdFieldRequest : IRequest<GetByIdFieldResponse>
    {
        public string Id { get; set; }
    }
}
