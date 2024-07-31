using AutoMapper;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Branch.Update
{
    public class BranchUpdateHandler : IRequestHandler<BranchUpdateRequest, BranchUpdateResponse>
    {
        readonly IBranchReadRepository _branchReadRepository;
        readonly IBranchWriteRepository _branchWriteRepository;
        readonly IMapper _mapper;

        public BranchUpdateHandler(IBranchReadRepository branchReadRepository, IBranchWriteRepository branchWriteRepository, IMapper mapper)
        {
            _branchReadRepository = branchReadRepository;
            _branchWriteRepository = branchWriteRepository;
            _mapper = mapper;
        }

        public async Task<BranchUpdateResponse> Handle(BranchUpdateRequest request, CancellationToken cancellationToken)
        {
            T.Branch branch = await _branchReadRepository.GetByIdAsync(request.Id);
            branch = _mapper.Map(request, branch);

            await _branchWriteRepository.SaveAsync();

            return _mapper.Map<BranchUpdateResponse>(branch);
        }
    }
}