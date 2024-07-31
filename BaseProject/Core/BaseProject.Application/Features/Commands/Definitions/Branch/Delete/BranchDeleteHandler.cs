using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Branch.Delete
{
    public class BranchDeleteHandler : IRequestHandler<BranchDeleteRequest, BranchDeleteResponse>
    {
        readonly IBranchWriteRepository _branchWriteRepository;

        public BranchDeleteHandler(IBranchWriteRepository branchWriteRepository)
        {
            _branchWriteRepository = branchWriteRepository;
        }

        public async Task<BranchDeleteResponse> Handle(BranchDeleteRequest request, CancellationToken cancellationToken)
        {
            await _branchWriteRepository.SoftDeleteAsync(request.Id);
            await _branchWriteRepository.SaveAsync();

            return new();
        }
    }
}