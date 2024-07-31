using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Company.GetAll
{
    public class CompanyGetAllRequest: IRequest<CompanyGetAllResponse> 
    {
        public int Page { get; set; } = 0;

        public int Size { get; set; } = 5;
    }
}
