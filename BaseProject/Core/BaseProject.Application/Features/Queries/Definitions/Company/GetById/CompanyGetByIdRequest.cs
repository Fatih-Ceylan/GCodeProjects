using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Company.GetById
{
    public class CompanyGetByIdRequest: IRequest<CompanyGetByIdResponse>
    {
        public string Id { get; set; }
    }
}
