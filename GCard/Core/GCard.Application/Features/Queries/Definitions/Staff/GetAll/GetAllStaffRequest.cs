using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Staff.GetAll
{
    public class GetAllStaffRequest : Pagination, IRequest<GetAllStaffResponse>
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
