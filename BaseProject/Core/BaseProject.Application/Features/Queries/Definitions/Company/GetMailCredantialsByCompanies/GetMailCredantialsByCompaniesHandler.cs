using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.VMs.Definitions.Branch;
using BaseProject.Application.VMs.Definitions.Company;
using BaseProject.Application.VMs.Definitions.MailCredantial;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Company.GetMailCredantialsByCompanies
{
    public class GetMailCredantialsByCompaniesHandler : IRequestHandler<GetMailCredantialsByCompaniesRequest, GetMailCredantialsByCompaniesResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IBranchReadRepository _branchReadRepository;
        readonly IMailCredantialReadRepository _mailCredantReadRepository;

        public GetMailCredantialsByCompaniesHandler(ICompanyReadRepository companyReadRepository, IBranchReadRepository branchReadRepository, IMailCredantialReadRepository mailCredantReadRepository)
        {
            _companyReadRepository = companyReadRepository;
            _branchReadRepository = branchReadRepository;
            _mailCredantReadRepository = mailCredantReadRepository;
        }

        public async Task<GetMailCredantialsByCompaniesResponse> Handle(GetMailCredantialsByCompaniesRequest request, CancellationToken cancellationToken)
        {
            var companyMailCredantials = _companyReadRepository.GetAllDeletedStatusDesc(false)
                                                  .Select(c => new CompanyMailCredantialVM
                                                  {
                                                      Id = c.Id.ToString(),
                                                      Name = c.Name,
                                                      BranchCount = _branchReadRepository.GetAllDeletedStatusDesc(false, false)
                                                                                         .Where(b => b.CompanyId == c.Id)
                                                                                         .Count(),
                                                      Branches = _branchReadRepository.GetAllDeletedStatusDesc(false, false)
                                                                                                                .Where(b => b.CompanyId == c.Id)
                                                                                                                .Select(b => new BranchMailCredantialVM
                                                                                                                {
                                                                                                                    Id = b.Id.ToString(),
                                                                                                                    Name = b.Name,
                                                                                                                    MailCredantial = _mailCredantReadRepository.GetAllDeletedStatusDesc(false, false)
                                                                                                                           .Where(mc => mc.BranchId == b.Id)
                                                                                                                           .Select(mc => new MailCredantialUpdateVM
                                                                                                                           {
                                                                                                                               Id = mc.Id.ToString(),
                                                                                                                               From = mc.From
                                                                                                                           })
                                                                                                                           .FirstOrDefault()
                                                                                                                })
                                                                                                                .ToList()
                                                                                                            
                                                  }).ToList();

                                                

            return new()
            {
                TotalCount = companyMailCredantials.Count,
                CompanyMailCredantials = companyMailCredantials
            };
        }
    }
}