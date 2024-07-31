using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Department.Update
{
    public class DepartmentUpdateRequest: IRequest<DepartmentUpdateResponse>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string? MainDepartmentId { get; set; }
    }
}