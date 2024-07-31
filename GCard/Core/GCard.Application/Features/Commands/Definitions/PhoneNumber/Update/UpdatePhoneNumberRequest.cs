using MediatR;

namespace GCard.Application.Features.Commands.Definitions.PhoneNumber.Update
{
    public class UpdatePhoneNumberRequest : IRequest<UpdatePhoneNumberResponse>
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public string StaffId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
