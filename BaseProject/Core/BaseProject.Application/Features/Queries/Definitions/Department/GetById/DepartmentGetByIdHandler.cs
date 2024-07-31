using AutoMapper;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using T = BaseProject.Domain.Entities.Definitions;
using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.Department.GetById
{
    public class DepartmentGetByIdHandler : IRequestHandler<DepartmentGetByIdRequest, DepartmentGetByIdResponse>
    {
        readonly IDepartmentReadRepository _departmentReadRepository;
        readonly IMapper _mapper;

        public DepartmentGetByIdHandler(IDepartmentReadRepository departmentReadRepository, IMapper mapper)
        {
            _departmentReadRepository = departmentReadRepository;
            _mapper = mapper;
        }

        public async Task<DepartmentGetByIdResponse> Handle(DepartmentGetByIdRequest request, CancellationToken cancellationToken)
        {
            T.Department department = await _departmentReadRepository.GetByIdAsync(request.Id, false);

            return _mapper.Map<DepartmentGetByIdResponse>(department);
        }
    }
}
