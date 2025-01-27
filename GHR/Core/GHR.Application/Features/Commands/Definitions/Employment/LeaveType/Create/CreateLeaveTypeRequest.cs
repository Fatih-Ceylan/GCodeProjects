﻿using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.LeaveType.Create
{
    public class CreateLeaveTypeRequest : IRequest<CreateLeaveTypeResponse>
    {
        public string? Code { get; set; }

        public string? Name { get; set; }
    }
}
