using GCard.Application.Repositories.ReadRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using QRCoder;
using SixLabors.ImageSharp;
using Utilities.Core.UtilityApplication.Enums;
using Image = SixLabors.ImageSharp.Image;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.GetQrCode
{
    public class GetQrCodeHandler : IRequestHandler<GetQrCodeRequest, GetQrCodeResponse>
    {
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IStaffReadRepository _staffReadRepository;

        public GetQrCodeHandler(IHttpContextAccessor httpContextAccessor, IStaffReadRepository staffReadRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _staffReadRepository = staffReadRepository;
        }

        public async Task<GetQrCodeResponse> Handle(GetQrCodeRequest request, CancellationToken cancellationToken)
        {
            var route = _httpContextAccessor?.HttpContext?.Request?.Headers?["Route-Name"];
            string userId = request.Id.ToString();

            var userExist = _staffReadRepository.GetWhere(x => x.Id.ToString() == userId && x.IsDeleted == false).FirstOrDefault();

            if (userExist == null)
            {
                return new() { QrCodeBase64 = null , Message=CommandResponseMessage.UserNotFound.ToString() , StatusCode="404"};
            } 

            string baseUrl = $"http://10.0.0.55:7000/{route}/gcard-userqr";
            string qrCodeUrl = $"{baseUrl}/{userId}";

            string qrData = qrCodeUrl;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);

            BitmapByteQRCode qrCodeImage = new BitmapByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCodeImage.GetGraphic(20);

            using (MemoryStream ms = new MemoryStream(qrCodeBytes))
            {
                Image image = Image.Load(ms);

                using (MemoryStream msBase64 = new MemoryStream())
                {
                    image.SaveAsPng(msBase64);
                    byte[] imageBytes = msBase64.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);

                    // Base64 dizeyi dönüş yaparken kullanabilirsiniz
                    return new()
                    {
                        QrCodeBase64 = base64String,
                        Url = qrCodeUrl,
                        Message = CommandResponseMessage.Success.ToString(),
                        StatusCode="200"
                    };
                }
            }
        }
    }
}
