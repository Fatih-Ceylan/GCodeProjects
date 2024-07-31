using Platform.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace Platform.Application.Features.Commands.Definitions.Company.Delete
{
    public class CompanyDeleteHandler : IRequestHandler<CompanyDeleteRequest, CompanyDeleteResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public CompanyDeleteHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<CompanyDeleteResponse> Handle(CompanyDeleteRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.SoftDeleteAsync(request.Id);
            await _companyWriteRepository.SaveAsync();

            return new()
            {
                Message = CommandResponseMessage.DeletedSucces.ToString()
            };
        }
    }
}
