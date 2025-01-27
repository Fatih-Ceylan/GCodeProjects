﻿using GControl.Application.Features.Commands.Definitions.Announcement.Create;
using GControl.Application.Features.Commands.Definitions.Announcement.Delete;
using GControl.Application.Features.Commands.Definitions.Announcement.Update;
using GControl.Application.Features.Queries.Definitions.Announcement.GetAll;
using GControl.Application.Features.Queries.Definitions.Announcement.GetById;
using GControl.Application.Features.Queries.Definitions.Announcement.IsDeletedAnnouncement;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GControl.Api.Controllers.Definitions
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class AnnouncementController : ControllerBase
    {
        readonly IMediator _mediator;

        public AnnouncementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAnnouncementRequest request)
        {
            GetAllAnnouncementResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdAnnouncementRequest request)
        {
            GetByIdAnnouncementResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] CreateAnnouncementRequest request)
        {
            CreateAnnouncementResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateAnnouncementRequest request)
        {
            UpdateAnnouncementResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteAnnouncementRequest request)
        {
            DeleteAnnouncementResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> DeletedAnnouncement([FromQuery] IsDeletedAnnouncementRequest request)
        {
            IsDeletedAnnouncementResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

