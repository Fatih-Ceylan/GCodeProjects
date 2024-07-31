using GCard.Application.Features.Commands.Definitions.StaffContact.Create;
using GCard.Application.Features.Commands.Definitions.StaffContact.Delete;
using GCard.Application.Features.Commands.Definitions.StaffContact.Update;
using GCard.Application.Features.Queries.Definitions.StaffContact.DownloadQrCode;
using GCard.Application.Features.Queries.Definitions.StaffContact.GetAll;
using GCard.Application.Features.Queries.Definitions.StaffContact.GetById;
using GCard.Application.Features.Queries.Definitions.StaffContact.GetContactListByStaffId;
using GCard.Application.Features.Queries.Definitions.StaffContact.GetQrCode;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GCard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    [Authorize(AuthenticationSchemes = "Admin")]
    public class StaffContactController : ControllerBase
    {
        readonly IMediator _mediator;

        public StaffContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllStaffContactRequest request)
        {
            GetAllStaffContactResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdStaffContactRequest request)
        {
            GetByIdStaffContactResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetContactListByStaffId([FromRoute] GetContactListByStaffIdRequest request)
        {
            GetContactListByStaffIdResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] CreateStaffContactRequest request)
        {
            CreateStaffContactResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateStaffContactRequest request)
        {
            UpdateStaffContactResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteStaffContactRequest request)
        {
            DeleteStaffContactResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> DownloadQrCode([FromRoute] DownloadQrCodeRequest request)
        {
            DownloadQrCodeResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetQrCode([FromRoute] GetQrCodeRequest request)
        {
            GetQrCodeResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
