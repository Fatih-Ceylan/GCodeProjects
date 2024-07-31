using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.VMs.Definitions.MailCredantial;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetById
{
    public class GetByIdMailCredantialHandler : IRequestHandler<GetByIdMailCredantialRequest, GetByIdMailCredantialResponse>
    {
        readonly IMailCredantialReadRepository _mailCredantialReadRepository;

        public GetByIdMailCredantialHandler(IMailCredantialReadRepository mailCredantialReadRepository)
        {
            _mailCredantialReadRepository = mailCredantialReadRepository;
        }

        public async Task<GetByIdMailCredantialResponse> Handle(GetByIdMailCredantialRequest request, CancellationToken cancellationToken)
        {
            var mailCredantial = _mailCredantialReadRepository
                                .GetWhere(mc => mc.Id == Guid.Parse(request.Id), false)
                                .Select(mc => new MailCredantialVM
                                {
                                    Id = mc.Id.ToString(),
                                    CreatedDate = mc.CreatedDate,
                                    CompanyId = mc.CompanyId.ToString(),
                                    CompanyName = mc.Branch.Company.Name,
                                    BranchId = mc.BranchId.ToString(),
                                    BranchName = mc.Branch.Name,
                                    UserId = mc.UserId,
                                    UserName = mc.User.UserName,
                                    From = mc.From,
                                    DisplayName = mc.DisplayName,
                                    Port = mc.Port,
                                    Host = mc.Host,
                                    EnableSsl = mc.EnableSsl,
                                    IsVerified = mc.IsVerified,
                                    IsActive = mc.IsActive,
                                }).FirstOrDefault();

            return new()
            {
                MailCredantial = mailCredantial
            };
        }
    }
}