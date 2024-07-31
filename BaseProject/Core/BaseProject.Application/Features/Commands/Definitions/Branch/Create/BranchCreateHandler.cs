using AutoMapper;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using T = BaseProject.Domain.Entities.Definitions;

namespace BaseProject.Application.Features.Commands.Definitions.Branch.Create
{
    public class BranchCreateHandler : IRequestHandler<BranchCreateRequest, BranchCreateResponse>
    {
        readonly IBranchWriteRepository _branchWriteRepository;
        readonly IMapper _mapper;

        public BranchCreateHandler(IBranchWriteRepository branchWriteRepository, IMapper mapper)
        {
            _branchWriteRepository = branchWriteRepository;
            _mapper = mapper;
        }

        public async Task<BranchCreateResponse> Handle(BranchCreateRequest request, CancellationToken cancellationToken)
        {
            T.Branch branch = _mapper.Map<T.Branch>(request);

            await _branchWriteRepository.AddAsync(branch);
            await _branchWriteRepository.SaveAsync();

            return new();
        }
    }
}