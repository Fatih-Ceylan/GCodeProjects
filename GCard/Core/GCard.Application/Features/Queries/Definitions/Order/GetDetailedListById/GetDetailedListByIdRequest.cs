using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Order.GetDetailedListById
{
    public class GetDetailedListByIdRequest : Pagination, IRequest<GetDetailedListByIdResponse>
    {
        public string Id { get; set; } 
    }
}
