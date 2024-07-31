using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Card.GetAll
{
    public class GetAllCardRequest : Pagination, IRequest<GetAllCardResponse>
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
