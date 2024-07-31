using MediatR;

namespace Platform.Application.Features.Queries.Definitions.Company.GetById
{
    public class CompanyGetByIdRequest : IRequest<CompanyGetByIdResponse>
    {
        public string Id { get; set; }
    }
}
