using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.VMs.Definitions.MailCredantial;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetAll
{
    public class GetAllMailCredantialHandler : IRequestHandler<GetAllMailCredantialRequest, GetAllMailCredantialResponse>
    {
        readonly IMailCredantialReadRepository _mailCredantialReadRepository;

        public GetAllMailCredantialHandler(IMailCredantialReadRepository mailCredantialReadRepository)
        {
            _mailCredantialReadRepository = mailCredantialReadRepository;
        }

        public async Task<GetAllMailCredantialResponse> Handle(GetAllMailCredantialRequest request, CancellationToken cancellationToken)
        {
            var query = _mailCredantialReadRepository
                       .GetAllDeletedStatusDesc(false)
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
                       });
            var totalCount = query.Count();
            var mailCredantials = request.DoPagination ? query.Skip(request.Page * request.Size)
                                                              .Take(request.Size).ToList()
                                                       : query.ToList();

            return new()
            {
                TotalCount = totalCount,
                MailCredantials = mailCredantials
            };
        }
    }
}