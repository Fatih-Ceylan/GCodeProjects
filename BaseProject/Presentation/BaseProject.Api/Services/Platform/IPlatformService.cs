using BaseProject.Api.Services.Platform.GetAllGModules;
using BaseProject.Api.Services.Platform.GetAllLicenses;

namespace BaseProject.Api.Services.Platform
{
    public interface IPlatformService
    {
        Task<GetAllLicensesResponse> GetAllLicensesHandler();

        Task<GetAllGModulesResponse> GetAllGModulesHandler();
    }
}
