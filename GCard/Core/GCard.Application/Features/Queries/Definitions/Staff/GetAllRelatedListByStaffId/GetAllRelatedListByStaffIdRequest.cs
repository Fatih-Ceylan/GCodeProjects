using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Staff.GetAllRelatedListByStaffId
{
    public class GetAllRelatedListByStaffIdRequest : Pagination, IRequest<GetAllRelatedListByStaffIdResponse>
    {
        public string Id { get; set; } 
    }
}
