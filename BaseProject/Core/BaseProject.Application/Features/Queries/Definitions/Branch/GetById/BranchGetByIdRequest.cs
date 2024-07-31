using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Branch.GetById
{
    public class BranchGetByIdRequest: IRequest<BranchGetByIdResponse>
    {
        public string Id { get; set; }
    }
}
