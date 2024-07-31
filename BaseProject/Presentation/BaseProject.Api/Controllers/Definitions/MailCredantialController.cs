using BaseProject.Application.Features.Commands.Definitions.MailCredantial.Create;
using BaseProject.Application.Features.Commands.Definitions.MailCredantial.Delete;
using BaseProject.Application.Features.Commands.Definitions.MailCredantial.Update;
using BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetAll;
using BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Api.Controllers.Definitions
{
    [Route("api/[controller]")]
    [ApiController]
   
    //[Authorize(AuthenticationSchemes = "Admin")]

    public class MailCredantialController : ControllerBase
    {
        readonly IMediator _mediator;

        public MailCredantialController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllMailCredantialRequest request)
        {
            GetAllMailCredantialResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdMailCredantialRequest request)
        {
            GetByIdMailCredantialResponse response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] CreateMailCredantialRequest request)
        {
            CreateMailCredantialResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateMailCredantialRequest request)
        {
            UpdateMailCredantialResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteMailCredantialRequest request)
        {
            DeleteMailCredantialResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}