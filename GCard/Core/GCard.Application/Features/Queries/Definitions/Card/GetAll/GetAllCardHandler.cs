
using GCard.Application.Repositories.ReadRepository;
using GCard.Application.VMs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using T = BaseProject.Domain.Entities.GCard.Definitions;

namespace GCard.Application.Features.Queries.Definitions.Card.GetAll
{
    public class GetAllCardHandler : IRequestHandler<GetAllCardRequest, GetAllCardResponse>
    {
        readonly ICardReadRepository _cardReadRepository;

        public GetAllCardHandler(ICardReadRepository cardReadRepository)
        {
            _cardReadRepository = cardReadRepository;
        }

        public async Task<GetAllCardResponse> Handle(GetAllCardRequest request, CancellationToken cancellationToken)
        {
            IQueryable<T.Card> cardQuery = _cardReadRepository.GetAllDeletedStatusDesc(false); 
            var cards = await _cardReadRepository.GetAllDeletedStatusDesc(false).Select(c => new CardVM
            {
                Id = c.Id.ToString(),
                Name = c.Name,
                CreatedDate = c.CreatedDate,
                Price = c.Price,
                TaxRate = c.TaxRate, 
            }).ToListAsync(cancellationToken);

            var totalCount = cards.Count;
            var response = cards.Skip(request.Page * request.Size).Take(request.Size).ToList();

            return new GetAllCardResponse
            {
                TotalCount = totalCount,
                Cards = response
            };
        }
    }
}
