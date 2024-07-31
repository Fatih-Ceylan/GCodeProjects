using MediatR;

namespace GHR.Application.Features.Commands.Definitions.Recruitment.Applications.JobApplicationStatus.Update
{
    public class UpdateJobApplicationStatusRequest : IRequest<UpdateJobApplicationStatusResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
