using GCard.Application.VMs;

namespace GCard.Application.Features.Commands.Definitions.StaffField.UpdateWithList
{
    public class UpdateWithListStaffFieldResponse
    {
        public List<StaffFieldVM> StaffFields { get; set; }
        public string Message { get; set; }
    }
}
