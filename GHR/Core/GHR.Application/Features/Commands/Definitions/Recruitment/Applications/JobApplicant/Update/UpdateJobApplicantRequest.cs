﻿using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Recruitment.Applications.JobApplicant.Update
{
    public class UpdateJobApplicantRequest : IRequest<UpdateJobApplicantResponse>
    {
        public string Id { get; set; }

        public string? Code { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Summary { get; set; }

        public string? JobAdvertId { get; set; }

        public string? JobApplicantDocumentId { get; set; }

        public string? Message { get; set; }
    }
}
