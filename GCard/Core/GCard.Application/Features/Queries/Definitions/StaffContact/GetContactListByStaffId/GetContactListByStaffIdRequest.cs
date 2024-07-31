using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.GetContactListByStaffId
{
    public class GetContactListByStaffIdRequest : Pagination, IRequest<GetContactListByStaffIdResponse>
    {
        public string Id { get; set; }
    }
}
