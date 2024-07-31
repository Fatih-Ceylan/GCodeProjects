using Platform.Application.Features.Commands.Definitions.Company.Create;
using Platform.Application.Features.Commands.Definitions.Company.Delete;

namespace Platform.Api.Services.Company
{
    public interface ICompanyService
    {
        Task<CreateCompanyResponse> Create(CreateCompanyRequest request, string accessToken);

        Task<DeleteCompanyResponse> Delete(DeleteCompanyRequest request, string accessToken);
    }
}
