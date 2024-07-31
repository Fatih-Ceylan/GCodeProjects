using MediatR;

namespace Platform.Application.Features.Commands.Definitions.Licence.Create
{
    public class LicenceCreateRequest : IRequest<LicenceCreateREsponse>
    {
        public string? LicenseKey { get; set; }
        public string? ProductName { get; set; }
        public string? ProductVersion { get; set; }
        public string? LicenseType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool Activated { get; set; }
        public int? MaxUsers { get; set; }
        public Guid? CompanyId { get; set; }
        public string DBName { get; set; }
        public string ConnectionString { get; set; }
    }
}
