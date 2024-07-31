using GControl.Application.Repositories.ReadRepository;
using GControl.Application.VMs.Definitions;
using MediatR;
using Newtonsoft.Json;
using QRCoder;
using SixLabors.ImageSharp;

namespace GControl.Application.Features.Queries.Definitions.Location.DownloadQrCode
{
    public class DownloadQrCodeHandler : IRequestHandler<DownloadQrCodeRequest, DownloadQrCodeResponse>
    {
        readonly ILocationReadRepository _locationReadRepository;

        public DownloadQrCodeHandler(ILocationReadRepository locationReadRepository)
        {
            _locationReadRepository = locationReadRepository;
        }

        public async Task<DownloadQrCodeResponse> Handle(DownloadQrCodeRequest request, CancellationToken cancellationToken)
        {
            string locationId = request.Id;
            var location = await _locationReadRepository.GetByIdAsync(locationId);
            LocationQRVM locationQRVM = new LocationQRVM()
            {
                Name = location.Name,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Radius = location.Radius,
                Address = location.Address,
                EntryTimeLimit = location.EntryTimeLimit,
                IsEntryTimeLimitEnabled = location.IsEntryTimeLimitEnabled,
            };
            string json = "";
            if (locationQRVM != null)
            {
                json = JsonConvert.SerializeObject(locationQRVM);
                // json verisini kullanabilirsiniz
            }
            //todo url'i appsettings'den çek
            string baseUrl = "http://10.0.0.55:5002";
            //string baseUrl = "http://localhost:7293";

            string qrCodeUrl = $"{baseUrl}/{locationId}";

            string qrData = json;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);

            BitmapByteQRCode qrCodeImage = new BitmapByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCodeImage.GetGraphic(20);

            using (MemoryStream ms = new MemoryStream(qrCodeBytes))
            {
                Image image = Image.Load(ms);

                string filePath = $"wwwroot/Location-QRCodes/qrcode_{request.Id}.png";
                string savedPath = $"Location-QRCodes/qrcode_{request.Id}.png";
                image.Save(filePath);
                return new DownloadQrCodeResponse
                {
                    QrCodePath = savedPath
                };
            }


        }
    }
}
