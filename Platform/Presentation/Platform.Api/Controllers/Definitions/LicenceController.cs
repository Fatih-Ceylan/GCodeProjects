using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Platform.Application.Features.Commands.Definitions.Licence.Create;
using Platform.Application.Features.Queries.Definitions.Licence.GetById;
using System.Net;

namespace Platform.Api.Controllers.Definitions
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class LicenceController : ControllerBase
    {
        readonly IMediator _mediator;

        public LicenceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] LicenceGetByIdRequest requestGetByIdLicence)
        {
            LicenceGetByIdResponse response = await _mediator.Send(requestGetByIdLicence);

            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] LicenceCreateRequest request)
        {
            LicenceCreateREsponse response = await _mediator.Send(request);

            //return Ok(response);
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}