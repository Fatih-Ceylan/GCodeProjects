using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Branch.Delete
{
    public class BranchDeleteRequest: IRequest<BranchDeleteResponse>
    {
        public string Id { get; set; }
    }
}
