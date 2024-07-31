using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Branch.Create
{
    public class BranchCreateRequest: IRequest<BranchCreateResponse>
    {
        public string Name { get; set; }

        public string CompanyId { get; set; }
    }
}