﻿using Utilities.Core.UtilityApplication.VMs;

namespace GHR.Application.Features.Commands.Definitions.Recruitment.Jobs.JobAdvert.VM
{
    public class CreateJobAdvertVM :BaseVM
    {
        public string? JobTitle { get; set; }

        public string? Code { get; set; }

        public string? CompanyName { get; set; }

        public string? Description { get; set; }

        public int? NumberOfVacancy { get; set; }

        public DateTime? PostingDate { get; set; }

        public string? AppellationId { get; set; }

        public string? AppellationName { get; set; }

        public string? WorkLocation { get; set; }
    }
}
