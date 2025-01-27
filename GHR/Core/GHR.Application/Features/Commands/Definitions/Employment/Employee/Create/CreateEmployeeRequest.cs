﻿using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.Employee.Create
{
    public class CreateEmployeeRequest : IRequest<CreateEmployeeResponse>
    {
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string? Token { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? HireDate { get; set; }

        public float? Salary { get; set; }

        public string? CompanyId { get; set; }

        public string? BranchId { get; set; }

        public string? DepartmentId { get; set; }

        public string? AppellationId { get; set; }

        public string? ManagedDepartmentId { get; set; }

        public string? ManagerId { get; set; }
    }
}
