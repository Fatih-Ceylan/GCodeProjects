using BaseProject.Api.Services.Platform.VMs;

namespace BaseProject.Api.Services.Platform.GetAllGModules
{
    public class GetAllGModulesResponse
    {
        public int TotalCount { get; set; }

        public List<GModuleVM> GModules { get; set; }
    }
}
