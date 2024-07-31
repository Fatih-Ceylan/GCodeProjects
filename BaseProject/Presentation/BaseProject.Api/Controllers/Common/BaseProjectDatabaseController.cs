using BaseProject.Persistence.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Api.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class BaseProjectDatabaseController : ControllerBase
    {
        [HttpGet("[action]/{DbName}")]
        public async Task<IActionResult> Create([FromRoute] string DbName)
        {
            //_baseProjectDbContext.Database.GetDbConnection().ConnectionString = $"Server = 10.0.0.95; Database = {DbName}; User Id = sa; Password = aysun2188; TrustServerCertificate = True";
            //await _baseProjectDbContext.UpdateDatabase();

            return Ok("Database Added Success");
        }
    }
}