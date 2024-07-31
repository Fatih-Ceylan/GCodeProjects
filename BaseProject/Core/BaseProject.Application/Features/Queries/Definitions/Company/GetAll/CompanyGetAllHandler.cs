using BaseProject.Application.Repositories.ReadRepository.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Company.GetAll
{
    public class CompanyGetAllHandler : IRequestHandler<CompanyGetAllRequest, CompanyGetAllResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;

        public CompanyGetAllHandler(ICompanyReadRepository companyReadRepository)
        {
            _companyReadRepository = companyReadRepository;
        }

        public Task<CompanyGetAllResponse> Handle(CompanyGetAllRequest request, CancellationToken cancellationToken)
        {

            var totalCount = _companyReadRepository.GetAllDeletedStatus(false).Count();
            var companies = _companyReadRepository.GetAllDeletedStatusDescending(false)
                                             .Skip(request.Page * request.Size)
                                             .Take(request.Size).ToList();

            return Task.FromResult(new CompanyGetAllResponse
            {
                TotalCount = totalCount,
                Companies = companies,
            });
        }
    }
}