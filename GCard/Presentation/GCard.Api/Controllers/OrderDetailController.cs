using GCard.Application.Features.Commands.Definitions.OrderDetail.Create;
using GCard.Application.Features.Commands.Definitions.OrderDetail.Delete;
using GCard.Application.Features.Commands.Definitions.OrderDetail.Update;
using GCard.Application.Features.Queries.Definitions.OrderDetail.GetAll;
using GCard.Application.Features.Queries.Definitions.OrderDetail.GetById;
using GCard.Application.Features.Queries.Definitions.OrderDetail.GetListByOrderId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GCard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    //[Authorize(AuthenticationSchemes = "Admin")]
    public class OrderDetailController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllOrderDetailRequest request)
        {
            GetAllOrderDetailResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdOrderDetailRequest request)
        {
            GetByIdOrderDetailResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetListByOrderId([FromRoute] GetListByOrderIdRequest request)
        {
            GetListByOrderIdResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] CreateOrderDetailRequest request)
        {
            CreateOrderDetailResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateOrderDetailRequest request)
        {
            UpdateOrderDetailResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOrderDetailRequest request)
        {
            DeleteOrderDetailResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
