using AutoMapper;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;
using System.Linq.Expressions;
using BaseProject.Application.DTOs.Definitions;

namespace BaseProject.Application.Features.Queries.Definitions.Branch.GetById
{
    public class BranchGetByIdHandler : IRequestHandler<BranchGetByIdRequest, BranchGetByIdResponse>
    {
        readonly IBranchReadRepository _branchReadRepository;
        readonly IMapper _mapper;
        public BranchGetByIdHandler(IBranchReadRepository branchReadRepository, IMapper mapper)
        {
            _branchReadRepository = branchReadRepository;
            _mapper = mapper;
        }

        public async Task<BranchGetByIdResponse> Handle(BranchGetByIdRequest request, CancellationToken cancellationToken)
        {

            T.Branch branch = await _branchReadRepository.GetByIdAsyncIncluding(new Expression<Func<T.Branch, object>>[] {
                                                                         x => x.Company
                                                                 }, request.Id, false);
            return await Task.FromResult(new BranchGetByIdResponse
            {
                Branch = _mapper.Map<BranchFullDTO>(branch),
            });
        }
    }
}
