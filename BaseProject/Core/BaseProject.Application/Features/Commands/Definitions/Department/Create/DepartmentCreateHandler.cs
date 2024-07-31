using AutoMapper;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.Department.Create
{
    public class DepartmentCreateHandler : IRequestHandler<DepartmentCreateRequest, DepartmentCreateResponse>
    {
        readonly IDepartmentWriteRepository _departmentWriteRepository;
        readonly IMapper _mapper;

        public DepartmentCreateHandler(IDepartmentWriteRepository departmentWriteRepository, IMapper mapper)
        {
            _departmentWriteRepository = departmentWriteRepository;
            _mapper = mapper;
        }

        public async Task<DepartmentCreateResponse> Handle(DepartmentCreateRequest request, CancellationToken cancellationToken)
        {
            T.Department department = _mapper.Map<T.Department>(request);

            await _departmentWriteRepository.AddAsync(department);
            await _departmentWriteRepository.SaveAsync();

            return new();
        }
    }
}