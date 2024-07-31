using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.StaffField.GetAllFieldByStaffId
{
    public class GetAllFieldByStaffIdStaffFieldRequest : Pagination, IRequest<GetAllFieldByStaffIdStaffFieldResponse>
    {
        public string Id { get; set; }
    }
}
