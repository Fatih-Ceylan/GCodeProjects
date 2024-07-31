using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Department.Create
{
    public class DepartmentCreateRequest: IRequest<DepartmentCreateResponse>
    {
        public string Name { get; set; }

        public string? MainDepartmentId { get; set; }
    }
}