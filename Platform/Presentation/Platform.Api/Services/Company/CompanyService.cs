using BaseProject.Application.Repositories;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using Platform.Application.Abstractions.Services;
using Platform.Application.DTOs.Identity.AppUser;
using Platform.Application.Features.Commands.Definitions.Company.Create;
using Platform.Application.Features.Commands.Definitions.Company.Delete;
using Utilities.Core.UtilityApplication.Exceptions;
using Utilities.Infrastructure.UtilityInfrastructure.Operations;
using T = BaseProject.Domain.Entities.Definitions;

namespace Platform.Api.Services.Company
{
    public class CompanyService : ICompanyService
    {
        readonly IMediator _mediator;
        readonly IBaseProjectDbContext _baseProjectDbContext;
        readonly IBaseProjectService _baseProjectService;
        readonly ICompanyWriteRepository _baseProjectCompanyWriteRepository;

        public CompanyService(IMediator mediator, IBaseProjectDbContext baseProjectDbContext, IBaseProjectService baseProjectService, ICompanyWriteRepository baseProjectCompanyWriteRepository)
        {
            _mediator = mediator;
            _baseProjectDbContext = baseProjectDbContext;
            _baseProjectService = baseProjectService;
            _baseProjectCompanyWriteRepository = baseProjectCompanyWriteRepository;
        }

        public async Task<CreateCompanyResponse> Create(CreateCompanyRequest request,string accessToken)
        {
            if (request.AdminUserPassword == request.AdminUserPasswordConfirm)
            {
                request.BaseDbName = NameOperation.CharacterRegulatory(request.BaseDbName).ToLower();
                CreateCompanyResponse response = await _mediator.Send(request);

                _baseProjectDbContext.BaseProjectUpdateDatabase(request.BaseDbName);
                response.MessageList.Add($"{request.BaseDbName}_base database has been created.");

                CreateUserRequestDTO user = new();
                user.FullName = request.AdminUserFullName;
                user.UserName = request.AdminUserEmail;
                user.Email = request.AdminUserEmail;
                user.Password = request.AdminUserPassword;
                user.PasswordConfirm = request.AdminUserPasswordConfirm;

                var createdUserResponseMessage = await _baseProjectService.AddUser(user, accessToken, request.BaseDbName);
                if (createdUserResponseMessage != null)
                    response.MessageList.Add($"{user.UserName} {createdUserResponseMessage} to {request.BaseDbName}_base database");

                await AddCompanyForBaseProject(request, response);

               return response;
            }
            else
            {
                throw new PasswordConfirmException();
            }
        }

        public async Task<CreateCompanyResponse> AddCompanyForBaseProject(CreateCompanyRequest request, CreateCompanyResponse response)
        {
            T.Company baseProjectCompany = new();
            baseProjectCompany.Name = request.Name;
            baseProjectCompany.LogoPath = response.LogoPath;
            baseProjectCompany.AuthorizedFullName = request.AuthorizedFullName;
            baseProjectCompany.PhoneNumber = request.PhoneNumber;
            baseProjectCompany.FaxNo = request.FaxNo;
            baseProjectCompany.Email = request.Email;
            baseProjectCompany.WebAddress = request.WebAddress;
            baseProjectCompany.TaxOffice = request.TaxOffice;
            baseProjectCompany.TaxNo = request.TaxNo;
            baseProjectCompany.TradeRegisterNo = request.TradeRegisterNo;
            baseProjectCompany.SocialSecurityNo = request.SocialSecurityNo;
            baseProjectCompany.MersisNo = request.MersisNo;
            baseProjectCompany.MasterCompanyIdFromPlatform = Guid.Parse(response.Id);

            await _baseProjectCompanyWriteRepository.AddAsync(baseProjectCompany);
            await _baseProjectCompanyWriteRepository.SaveAsync();

            response.MessageList.Add($"{request.Name} Company was added to the {request.BaseDbName}_base database as the parent company.");
            
            return response;
        }

        public async Task<CreateCompanyResponse> AddUserForBaseProject(CreateCompanyRequest request, CreateCompanyResponse response)
        {
            T.Company baseProjectCompany = new();
            baseProjectCompany.Name = request.Name;
            baseProjectCompany.LogoPath = response.LogoPath;
            baseProjectCompany.AuthorizedFullName = request.AuthorizedFullName;
            baseProjectCompany.PhoneNumber = request.PhoneNumber;
            baseProjectCompany.FaxNo = request.FaxNo;
            baseProjectCompany.Email = request.Email;
            baseProjectCompany.WebAddress = request.WebAddress;
            baseProjectCompany.TaxOffice = request.TaxOffice;
            baseProjectCompany.TaxNo = request.TaxNo;
            baseProjectCompany.TradeRegisterNo = request.TradeRegisterNo;
            baseProjectCompany.SocialSecurityNo = request.SocialSecurityNo;
            baseProjectCompany.MersisNo = request.MersisNo;
            baseProjectCompany.MasterCompanyIdFromPlatform = Guid.Parse(response.Id);

            await _baseProjectCompanyWriteRepository.AddAsync(baseProjectCompany);
            await _baseProjectCompanyWriteRepository.SaveAsync();

            response.MessageList.Add($"{request.Name} Company was added to the {request.BaseDbName}_base database as the parent company.");

            return response;
        }

        public async Task<DeleteCompanyResponse> Delete(DeleteCompanyRequest request, string accessToken)
        {
            DeleteCompanyResponse response = await _mediator.Send(request);
            var deletedUserResponseMessage = await _baseProjectService.SoftDeleteAllUsers(accessToken, response.UrlPath);

            if (deletedUserResponseMessage != null)
                response.MessageList.Add($"{deletedUserResponseMessage} from {response.UrlPath}_base database");

            return response;
        }
    }
}
