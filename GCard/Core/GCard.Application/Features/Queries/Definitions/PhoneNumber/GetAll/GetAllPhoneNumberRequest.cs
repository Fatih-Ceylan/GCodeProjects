using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.PhoneNumber.GetAll
{
    public class GetAllPhoneNumberRequest : Pagination, IRequest<GetAllPhoneNumberResponse>
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
