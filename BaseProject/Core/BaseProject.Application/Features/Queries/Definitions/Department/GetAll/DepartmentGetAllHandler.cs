using BaseProject.Application.Repositories.ReadRepository.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Department.GetAll
{
    public class DepartmentGetAllHandler : IRequestHandler<DepartmentGetAllRequest, DepartmentGetAllResponse>
    {
        readonly IDepartmentReadRepository _departmentReadRepository;

        public DepartmentGetAllHandler(IDepartmentReadRepository departmentReadRepository)
        {
            _departmentReadRepository = departmentReadRepository;
        }

        public Task<DepartmentGetAllResponse> Handle(DepartmentGetAllRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _departmentReadRepository.GetAllDeletedStatus(false).Count();
            var departments = _departmentReadRepository.GetAllDeletedStatusDescending(false)
                                             .Skip(request.Page * request.Size)
                                             .Take(request.Size).ToList();

            return Task.FromResult(new DepartmentGetAllResponse
            {
                TotalCount = totalCount,
                Departments = departments,
            });
        }
    }
}