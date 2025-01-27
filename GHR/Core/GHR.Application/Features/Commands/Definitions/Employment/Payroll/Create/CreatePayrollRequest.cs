﻿using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Employment.Payroll.Create
{
    public class CreatePayrollRequest : IRequest<CreatePayrollResponse>
    {
        public string? EmployeeId { get; set; }

        public DateTime? Date { get; set; }

        public int? DayCount { get; set; }

        public float? SalaryPaid { get; set; }

        public float? SalaryTotal { get; set; }
    }
}
