using BaseProject.Application.Repositories.ReadRepository.Definitions;
using MediatR;
using T = BaseProject.Domain.Entities.Definitions;
using System.Linq.Expressions;
using AutoMapper;
using BaseProject.Application.DTOs.Definitions;

namespace BaseProject.Application.Features.Queries.Definitions.Branch.GetAll
{
    public class BranchGetAllHandler : IRequestHandler<BranchGetAllRequest, BranchGetAllResponse>
    {
        readonly IBranchReadRepository _branchReadRepository;
        readonly IMapper _mapper;

        public BranchGetAllHandler(IBranchReadRepository branchReadRepository, IMapper mapper)
        {
            _branchReadRepository = branchReadRepository;
            _mapper = mapper;
        }

        public Task<BranchGetAllResponse> Handle(BranchGetAllRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _branchReadRepository.GetAllDeletedStatus(false).Count();
            var branches = _branchReadRepository.GetAllDeletedStatusIncluding(new Expression<Func<T.Branch, object>>[] {
                                                                         x => x.Company
                                                                 }, false)
                                                                 .Skip(request.Page * request.Size)
                                                                 .Take(request.Size).ToList();

            return Task.FromResult(new BranchGetAllResponse
            {
                TotalCount = totalCount,
                Branches = _mapper.Map<List<BranchFullDTO>>(branches),
            });
        }
    }
}