using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Branch.Update
{
    public class BranchUpdateRequest: IRequest<BranchUpdateResponse>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Guid? CompanyId { get; set; }
    }
}