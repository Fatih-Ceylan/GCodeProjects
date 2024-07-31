using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Recruitment.Applications.JobApplicationStatus.Create
{
    public class CreateJobApplicationStatusRequest : IRequest<CreateJobApplicationStatusResponse>
    {
        public string Name { get; set; }
    }
}
