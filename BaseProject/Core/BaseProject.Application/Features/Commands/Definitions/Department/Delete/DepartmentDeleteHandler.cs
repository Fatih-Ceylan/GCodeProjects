using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Department.Delete
{
    public class DepartmentDeleteHandler : IRequestHandler<DepartmentDeleteRequest, DepartmentDeleteResponse>
    {
        readonly IDepartmentWriteRepository _departmentWriteRepository;

        public DepartmentDeleteHandler(IDepartmentWriteRepository departmentWriteRepository)
        {
            _departmentWriteRepository = departmentWriteRepository;
        }

        public async Task<DepartmentDeleteResponse> Handle(DepartmentDeleteRequest request, CancellationToken cancellationToken)
        {
            await _departmentWriteRepository.SoftDeleteAsync(request.Id);
            await _departmentWriteRepository.SaveAsync();

            return new();
        }
    }
}