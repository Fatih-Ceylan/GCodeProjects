﻿using GHR.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace GHR.Application.Features.Commands.Definitions.Employment.Employee.Delete
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeRequest, DeleteEmployeeResponse>
    {
        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public DeleteEmployeeHandler(IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<DeleteEmployeeResponse> Handle(DeleteEmployeeRequest request, CancellationToken cancellationToken)
        {
            await _employeeWriteRepository.SoftDeleteAsync(request.Id);
            await _employeeWriteRepository.SaveAsync();

            return new()
            {
                Message = CommandResponseMessage.DeletedSuccess.ToString()
            };
        }
    }
}
