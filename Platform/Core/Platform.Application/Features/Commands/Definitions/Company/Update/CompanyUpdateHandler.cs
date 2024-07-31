using AutoMapper;
using Platform.Application.Repositories.ReadRepository.Definitions;
using Platform.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using T = Platform.Domain.Entities.Definitions;
using Utilities.Core.UtilityApplication.Enums;

namespace Platform.Application.Features.Commands.Definitions.Company.Update
{
    public class CompanyUpdateHandler : IRequestHandler<CompanyUpdateREquest, CompanyUpdateREsponse>
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

        public async Task<CompanyUpdateREsponse> Handle(CompanyUpdateREquest request, CancellationToken cancellationToken)
        {
            T.Company company = await _companyReadRepository.GetByIdAsync(request.Id);
            company = _mapper.Map(request, company);
            await _companyWriteRepository.SaveAsync();

            var responseUpdatedCompany = _mapper.Map<CompanyUpdateREsponse>(company);
            responseUpdatedCompany.Message = CommandResponseMessage.UpdatedSucces.ToString();
            
            return responseUpdatedCompany; 
        }
    }
}
