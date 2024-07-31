using AutoMapper;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;
using BaseProject.Application.Repositories.ReadRepository.Definitions;

namespace BaseProject.Application.Features.Commands.Definitions.Company.Update
{
    public class CompanyUpdateHandler : IRequestHandler<CompanyUpdateRequest, CompanyUpdateResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IMapper _mapper;

        public CompanyUpdateHandler(ICompanyWriteRepository companyWriteRepository, IMapper mapper, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
            _companyReadRepository = companyReadRepository;
        }

        public async Task<CompanyUpdateResponse> Handle(CompanyUpdateRequest request, CancellationToken cancellationToken)
        {
            T.Company company = await _companyReadRepository.GetByIdAsync(request.Id);
            company = _mapper.Map(request, company);

            await _companyWriteRepository.SaveAsync();

            return _mapper.Map<CompanyUpdateResponse>(company);
        }
    }
}