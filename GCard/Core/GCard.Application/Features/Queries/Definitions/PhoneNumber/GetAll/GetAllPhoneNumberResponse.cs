using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.PhoneNumber.GetAll
{
    public class GetAllPhoneNumberResponse
    {
        public int TotalCount { get; set; }

        public List<PhoneNumberVM> PhoneNumbers { get; set; }
    }
}
