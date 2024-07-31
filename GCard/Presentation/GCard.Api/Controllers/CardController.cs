using GCard.Application.Features.Commands.Definitions.Card.Create;
using GCard.Application.Features.Commands.Definitions.Card.Delete;
using GCard.Application.Features.Commands.Definitions.Card.Update;
using GCard.Application.Features.Queries.Definitions.Card.GetAll;
using GCard.Application.Features.Queries.Definitions.Card.GetById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GCard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    [Authorize(AuthenticationSchemes = "Admin")]
    public class CardController : ControllerBase
    { 
        readonly IMediator _mediator;

        public CardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCardRequest request)
        {
            GetAllCardResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCardRequest request)
        {
            GetByIdCardResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] CreateCardRequest request)
        {
            CreateCardResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateCardRequest request)
        {
            UpdateCardResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCardRequest request)
        {
            DeleteCardResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
