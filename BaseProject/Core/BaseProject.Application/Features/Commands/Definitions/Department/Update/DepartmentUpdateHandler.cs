using AutoMapper;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Department.Update
{
    public class DepartmentUpdateHandler : IRequestHandler<DepartmentUpdateRequest, DepartmentUpdateResponse>
    {
        readonly IDepartmentReadRepository _departmentReadRepository;
        readonly IDepartmentWriteRepository _departmentWriteRepository;
        readonly IMapper _mapper;

        public DepartmentUpdateHandler(IDepartmentReadRepository departmentReadRepository, IDepartmentWriteRepository departmentWriteRepository, IMapper mapper)
        {
            _departmentReadRepository = departmentReadRepository;
            _departmentWriteRepository = departmentWriteRepository;
            _mapper = mapper;
        }

        public async Task<DepartmentUpdateResponse> Handle(DepartmentUpdateRequest request, CancellationToken cancellationToken)
        {
            T.Department department = await _departmentReadRepository.GetByIdAsync(request.Id);
            department = _mapper.Map(request, department);

            await _departmentWriteRepository.SaveAsync();

            return _mapper.Map<DepartmentUpdateResponse>(department);
        }
    }
}