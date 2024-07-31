using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Department.Delete
{
    public class DepartmentDeleteRequest: IRequest<DepartmentDeleteResponse>
    {
        public string Id { get; set; }
    }
}