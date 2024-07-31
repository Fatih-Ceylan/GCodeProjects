using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Department.GetAll
{
    public class DepartmentGetAllRequest: IRequest<DepartmentGetAllResponse>
    {
        public int Page { get; set; } = 0;

        public int Size { get; set; } = 5;
    }
}