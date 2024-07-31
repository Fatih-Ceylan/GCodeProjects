using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Branch.GetAll
{
    public class BranchGetAllRequest: IRequest<BranchGetAllResponse>
    {
        public int Page { get; set; } = 0;

        public int Size { get; set; } = 5;
    }
}
