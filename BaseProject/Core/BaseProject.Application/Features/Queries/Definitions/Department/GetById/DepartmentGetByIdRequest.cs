using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Department.GetById
{
    public class DepartmentGetByIdRequest: IRequest<DepartmentGetByIdResponse>
    {
        public string Id { get; set; }
    }
}