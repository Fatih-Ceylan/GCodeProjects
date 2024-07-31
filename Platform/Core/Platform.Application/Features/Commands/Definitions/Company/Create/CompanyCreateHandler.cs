using AutoMapper;
using Platform.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using T = Platform.Domain.Entities.Definitions;
using Utilities.Core.UtilityApplication.Enums;
using Platform.Application.Repositories.WriteRepository.Definitions.Files;
using BaseProject.Application.Repositories;
using Utilities.Core.UtilityApplication.Absractions.Storage;

namespace Platform.Application.Features.Commands.Definitions.Company.Create
{
    public class CompanyCreateHandler : IRequestHandler<CompanyCreateRequest, CompanyCreateResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly IMapper _mapper;
        readonly IStorageService _storageService;
        readonly ICompanyFileWriteRepository _companyFileWriteRepository;
        readonly IBaseProjectDbContext _baseProjectDbContext;

        public CompanyCreateHandler(ICompanyWriteRepository companyWriteRepository, IMapper mapper, IStorageService storageService, ICompanyFileWriteRepository companyFileWriteRepository, IBaseProjectDbContext baseProjectDbContext)
        {
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
            _storageService = storageService;
            _companyFileWriteRepository = companyFileWriteRepository;
            _baseProjectDbContext = baseProjectDbContext;
        }

        public async Task<CompanyCreateResponse> Handle(CompanyCreateRequest request, CancellationToken cancellationToken)
        {
                try
                {
                    var uploadedDatas = await _storageService.UploadAsync("Company-Files", request.Files);

                    T.Company company = _mapper.Map<T.Company>(request);
                    company.LogoPath = uploadedDatas.Select(t => t.pathOrContainerName).FirstOrDefault();
                    company.BaseDbName = $"{company.BaseDbName}_Base";

                    var createdCompany = await _companyWriteRepository.AddAsync(company);

                    var responseCreatedCompany = _mapper.Map<CompanyCreateResponse>(createdCompany);
                    responseCreatedCompany.Message = CommandResponseMessage.AddedSucces.ToString();

                    await _companyFileWriteRepository.AddRangeAsync(uploadedDatas.Select(r => new T.Files.CompanyFile()
                    {
                        FileName = r.fileName,
                        Path = r.pathOrContainerName,
                        Storage = _storageService.StorageName,
                        Companies = new List<T.Company>() { createdCompany }
                    }).ToList());
                    await _companyWriteRepository.SaveAsync();

                _baseProjectDbContext.BaseProjectUpdateDatabase(company.BaseDbName);

                return responseCreatedCompany;

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
    }
}