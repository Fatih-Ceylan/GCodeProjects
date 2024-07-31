using MediatR;
using Microsoft.AspNetCore.Http;
using QRCoder;
using Image = SixLabors.ImageSharp.Image;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.DownloadQrCode
{
    public class DownloadQrCodeHandler : IRequestHandler<DownloadQrCodeRequest, DownloadQrCodeResponse>
    {
         IHttpContextAccessor _httpContextAccessor;

        public DownloadQrCodeHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<DownloadQrCodeResponse> Handle(DownloadQrCodeRequest request, CancellationToken cancellationToken)
        {
            var route = _httpContextAccessor?.HttpContext?.Request?.Headers?["Route-Name"];
            string userId = request.Id.ToString();
            string baseUrl = $"http://localhost:7000/{route}/gcard-userqr";
            string qrCodeUrl = $"{baseUrl}/{userId}";
             
            string qrData = qrCodeUrl;
             
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);

            BitmapByteQRCode qrCodeImage = new BitmapByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCodeImage.GetGraphic(20);

            using (MemoryStream ms = new MemoryStream(qrCodeBytes))
            {
                Image image = Image.Load(ms);

                //string filePath = $"wwwroot/qrcode_{request.Id}.png";
                //image.Save(filePath);
            }

            return new DownloadQrCodeResponse
            {
                DownloadQrCode = qrCodeUrl  
            };
        }
    }
}
