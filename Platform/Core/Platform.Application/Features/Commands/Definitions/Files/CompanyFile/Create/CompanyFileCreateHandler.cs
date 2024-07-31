using MediatR;
using Platform.Application.Repositories.ReadRepository.Definitions;
using Platform.Application.Repositories.WriteRepository.Definitions;
using Platform.Application.Repositories.WriteRepository.Definitions.Files;
using Utilities.Core.UtilityApplication.Absractions.Storage;
using Utilities.Core.UtilityApplication.Enums;
using T=Platform.Domain.Entities.Definitions;

namespace Platform.Application.Features.Commands.Definitions.Files.CompanyFile.Create
{
    public class CompanyFileCreateHandler : IRequestHandler<CompanyFileCreateRequest, CompanyFileCreateResponse>
    {
        readonly IStorageService _storageService;
        readonly ICompanyFileWriteRepository _companyFileWriteRepository;
        readonly ICompanyReadRepository _companyReadRepository;
        readonly ICompanyWriteRepository _companyWriteRepository;

        public CompanyFileCreateHandler(IStorageService storageService, ICompanyFileWriteRepository companyFileWriteRepository, ICompanyReadRepository companyReadRepository, ICompanyWriteRepository companyWriteRepository)
        {
            _storageService = storageService;
            _companyFileWriteRepository = companyFileWriteRepository;
            _companyReadRepository = companyReadRepository;
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<CompanyFileCreateResponse> Handle(CompanyFileCreateRequest request, CancellationToken cancellationToken)
        {
            var uploadedDatas = await _storageService.UploadAsync("Company-Files", request.Files);

            T.Company company = await _companyReadRepository.GetByIdAsync(request.Id);

            await _companyFileWriteRepository.AddRangeAsync(uploadedDatas.Select(r => new T.Files.CompanyFile()
            {
                FileName = r.fileName,
                Path = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                Companies = new List<T.Company>() { company }
            }).ToList());
            await _companyWriteRepository.SaveAsync();

            return new()
            {
                Message = CommandResponseMessage.AddedSucces.ToString()
            };
        }
    }
}