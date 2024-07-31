using BaseProject.Api.Services.Platform;
using BaseProject.Api.Services.Platform.GetAllGModules;
using BaseProject.Api.Services.Platform.GetAllLicenses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Api.Controllers.FromPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class FromPlatformController : ControllerBase
    {
        readonly IPlatformService _platformService;

        public FromPlatformController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        [HttpGet("getall-licenses")]
        public async Task<IActionResult> GetAllLicenses()
        {
            GetAllLicensesResponse response = await _platformService.GetAllLicensesHandler();
            
            return Ok(response);
        }

        [HttpGet("getall-gmodules")]
        public async Task<IActionResult> GetAllGModules()
        {
            GetAllGModulesResponse response = await _platformService.GetAllGModulesHandler();

            return Ok(response);
        }
    }
}