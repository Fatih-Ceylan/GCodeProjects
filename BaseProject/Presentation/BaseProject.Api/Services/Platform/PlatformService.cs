using BaseProject.Api.Services.Platform.GetAllGModules;
using BaseProject.Api.Services.Platform.GetAllLicenses;
using BaseProject.Api.Services.Platform.VMs;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using Platform.Application.Repositories.ReadRepository.Definitions;
using Utilities.Core.UtilityApplication.Abstractions.CurrentUser;

namespace BaseProject.Api.Services.Platform
{
    public class PlatformService : IPlatformService
    {
        readonly ILicenseReadRepository _licenseReadRepository;
        readonly IGModuleReadRepository _gModuleReadRepository;
        readonly IConfiguration _configuration;
        readonly ICompanyLicenseReadRepository _companyLicenseReadRepository;
        readonly ICurrentUserService _currentUserService;

        public PlatformService(ILicenseReadRepository licenseReadRepository, IGModuleReadRepository gModuleReadRepository, IConfiguration configuration, ICompanyLicenseReadRepository companyLicenseReadRepository, ICurrentUserService currentUserService)
        {
            _licenseReadRepository = licenseReadRepository;
            _gModuleReadRepository = gModuleReadRepository;
            _configuration = configuration;
            _companyLicenseReadRepository = companyLicenseReadRepository;
            _currentUserService = currentUserService;
        }

        public async Task<GetAllGModulesResponse> GetAllGModulesHandler()
        {
            var currentUser = await _currentUserService.GetCurrentUser();

            var gModules = _gModuleReadRepository.GetAllDeletedStatusDesc(false)
                                                 .Select(gm => new GModuleVM
                                                 {
                                                     Name = gm.Name,
                                                     LogoPath = _configuration["Storage:PlatformBaseStorageUrl"] + gm.LogoPath,
                                                     IsThereLicense = _licenseReadRepository.GetAllDeletedStatusDesc(false,false)
                                                                                            .Where(l => l.GModuleId == gm.Id && l.CompanyId == Guid.Parse(currentUser.MasterCompanyIdFromPlatform) && l.StartDate < DateTime.Today && l.ExpirationDate > DateTime.Today).Count() > 0 ? true : false
                                                 }).ToList();
            return new()
            {
                TotalCount = gModules.Count,
                GModules = gModules
            };
        }

        public async Task<GetAllLicensesResponse> GetAllLicensesHandler()
        {
            var currentUser = await _currentUserService.GetCurrentUser();

            var licenses = _licenseReadRepository.GetAllDeletedStatusDesc(false)
                                                        .Where(l => l.CompanyId == Guid.Parse(currentUser.MasterCompanyIdFromPlatform) && l.StartDate < DateTime.Today && l.ExpirationDate > DateTime.Today)
                                                        .Select(l => new LicenseVM
                                                        {
                                                            Id = l.Id.ToString(),
                                                            CreatedDate = l.CreatedDate,
                                                            GModuleId = l.GModuleId.ToString(),
                                                            GModuleName = l.GModule.Name,
                                                            LicenseTypeId = l.LicenseTypeId.ToString(),
                                                            LicenseTypeName = l.LicenseType.Name,
                                                            LicenseKey = l.LicenseKey.ToString(),
                                                            StartDate = l.StartDate,
                                                            ExpirationDate = l.ExpirationDate,
                                                            RemainingUsageDays = (l.ExpirationDate - DateTime.Today).Days < 0 ? 0 : (l.ExpirationDate - DateTime.Today).Days,
                                                            TotalCompanyNumber = l.TotalCompanyNumber,
                                                            TotalUserNumber = l.TotalUserNumber,
                                                        }).ToList();

            var companyLicenses = _companyLicenseReadRepository.GetAllDeletedStatus(false).Where(cl => cl.IsInUse == true).ToList();

            var result = (from l in licenses
                          select new LicenseVM
                          {
                              Id = l.Id,
                              CreatedDate = l.CreatedDate,
                              GModuleId = l.GModuleId,
                              GModuleName = l.GModuleName,
                              LicenseTypeId = l.LicenseTypeId,
                              LicenseTypeName = l.LicenseTypeName,
                              LicenseKey = l.LicenseKey,
                              StartDate = l.StartDate,
                              ExpirationDate = l.ExpirationDate,
                              RemainingUsageDays = (l.ExpirationDate - DateTime.Today).Days < 0 ? 0 : (l.ExpirationDate - DateTime.Today).Days,
                              TotalCompanyNumber = l.TotalCompanyNumber,
                              TotalUserNumber = l.TotalUserNumber,
                              UsingStatus = companyLicenses.Where(cl => cl.LicenseId == Guid.Parse(l.Id)).Count() > 0 ? true : false,
                              Using = companyLicenses.Where(cl => cl.LicenseId == Guid.Parse(l.Id)).Count(),
                              CanUse = l.TotalCompanyNumber - companyLicenses.Where(cl => cl.LicenseId == Guid.Parse(l.Id)).Count(),
                          }).ToList();

            return new()
            {
                TotalCount = result.Count,
                Licenses = result
            };
        }
    }
}