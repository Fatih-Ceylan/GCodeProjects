using MediatR;

namespace Platform.Application.Features.Commands.Definitions.Company.Delete
{
    public class CompanyDeleteRequest : IRequest<CompanyDeleteResponse>
    {
        public string Id { get; set; }
    }
}
