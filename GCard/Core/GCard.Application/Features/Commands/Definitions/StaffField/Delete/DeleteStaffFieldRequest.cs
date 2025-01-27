﻿using MediatR;

namespace GCard.Application.Features.Commands.Definitions.StaffField.Delete
{
    public class DeleteStaffFieldRequest : IRequest<DeleteStaffFieldResponse>
    {
        public string Id { get; set; }
    }
}
