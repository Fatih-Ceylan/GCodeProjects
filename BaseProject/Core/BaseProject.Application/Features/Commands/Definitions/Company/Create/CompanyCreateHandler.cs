using AutoMapper;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Company.Create
{
    public class CompanyCreateHandler : IRequestHandler<CompanyCreateRequest, CompanyCreateResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly IMapper _mapper;

        public CompanyCreateHandler(ICompanyWriteRepository companyWriteRepository, IMapper mapper)
        {
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
        }

        public async Task<CompanyCreateResponse> Handle(CompanyCreateRequest request, CancellationToken cancellationToken)
        {
            T.Company company =  _mapper.Map<T.Company>(request);

            await _companyWriteRepository.AddAsync(company);
            await _companyWriteRepository.SaveAsync();

            return new();
        }
    }
}