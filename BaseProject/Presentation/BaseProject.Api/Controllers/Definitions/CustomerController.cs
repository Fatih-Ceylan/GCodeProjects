using BaseProject.Application.Features.Commands.Definitions.Customer.Create;
using BaseProject.Application.Features.Queries.Definitions.Customer.GetAll;
using BaseProject.Application.Features.Queries.Definitions.Customer.GetById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BaseProject.Api.Controllers.Definitions
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class CustomerController : ControllerBase
    {
        readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
 
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] CustomerGetAllRequest requestGetAllCustomer)
        {
            CustomerGetAllResponse response = await _mediator.Send(requestGetAllCustomer);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] CustomerGetByIdRequest requestGetByIdCustomer)
        {
            CustomerGetByIdResponse response = await _mediator.Send(requestGetByIdCustomer);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CustomerCreateRequest requestCreateCustomer)
        {
            CustomerCreateResponse response = await _mediator.Send(requestCreateCustomer);
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}