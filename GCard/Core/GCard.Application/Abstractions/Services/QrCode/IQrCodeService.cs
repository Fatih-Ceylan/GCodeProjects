using GCard.Application.Features.Queries.Definitions.Order.GetStaffAndQrListByOrderId;
using GCard.Application.VMs;

namespace GCard.Application.Abstractions.Services.QrCode
{
    public interface IQrCodeService
    {
        Task<List<StaffAndQrListVM>> GenerateQrCode (GetStaffAndQrListByOrderIdRequest request);
    }
}
