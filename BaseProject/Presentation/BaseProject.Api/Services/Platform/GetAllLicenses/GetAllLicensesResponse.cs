using BaseProject.Api.Services.Platform.VMs;

namespace BaseProject.Api.Services.Platform.GetAllLicenses
{
    public class GetAllLicensesResponse
    {
        public int TotalCount { get; set; }

        public List<LicenseVM> Licenses { get; set; }
    }
}
