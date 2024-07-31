using BaseProject.Domain.Entities.GControl.Definitions;
using GControl.Application.Repositories.ReadRepository;
using GControl.Application.VMs.Definitions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using T = BaseProject.Domain.Entities.GControl.Definitions;

namespace GControl.Application.Features.Queries.Definitions.Employee.BringAllEmployee
{
    public class BringAllEmployeeHandler : IRequestHandler<BringAllEmployeeRequest, BringAllEmployeeResponse>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IEmployeeLabelReadRepository _employeeLabelReadRepository;
        readonly BaseProject.Application.Repositories.ReadRepository.Definitions.IDepartmentReadRepository _departmentReadRepository;
        public BringAllEmployeeHandler(IEmployeeReadRepository employeeReadRepository, BaseProject.Application.Repositories.ReadRepository.Definitions.IDepartmentReadRepository departmentReadRepository, IEmployeeLabelReadRepository employeeLabelReadRepository)
        {
            _employeeReadRepository = employeeReadRepository;
            _departmentReadRepository = departmentReadRepository;
            _employeeLabelReadRepository = employeeLabelReadRepository;
        }

        public Task<BringAllEmployeeResponse> Handle(BringAllEmployeeRequest request, CancellationToken cancellationToken)
        {
            var departmentList = _departmentReadRepository
                .GetAll()
                .Select(d => new DepartmentDDLVM
                {
                    Id = d.Id.ToString(),
                    Name = d.Name
                })
                .ToList();

            var query = _employeeReadRepository.GetAllDeletedStatusDesc(true,true)
                .Include(e => e.EmployeeLabels)
                .Include(e => e.EmployeeType)
                .Include(e => e.ShiftManagements)
                .Include(e => e.ApplicationSettings)
                .Select(e => new T.Employee
                {
                    Id = e.Id,
                    RegistrationNumber = e.RegistrationNumber,
                    FullName = e.FullName,
                    PhoneNumber = e.PhoneNumber,
                    StartWorkDate = e.StartWorkDate,
                    Email = e.Email,
                    EmployeeTypeId = e.EmployeeTypeId,
                    DepartmentId = e.DepartmentId,
                    CreatedDate = e.CreatedDate,
                    EmployeeLabels= e.EmployeeLabels,
                    EmployeeType = e.EmployeeType,
                    ShiftManagements = e.ShiftManagements,
                    ApplicationSettings = e.ApplicationSettings
                });

            var totalCount = query.Count();
            // todo: bu sorgu kısaltılacak
            var employees = query.Skip(request.Page * request.Size)
                                 .Take(request.Size).ToList();

            var result = (from e in employees
                          join dept in departmentList on e.DepartmentId.ToString().ToUpper() equals dept.Id into deptJoin
                          from dept in deptJoin.DefaultIfEmpty()
                          select new EmployeeVM
                          {
                              Id = e.Id.ToString(),
                              RegistrationNumber = e.RegistrationNumber,
                              FullName = e.FullName,
                              PhoneNumber = e.PhoneNumber,
                              StartWorkDate = e.StartWorkDate,
                              Email = e.Email,
                              EmployeeTypeId = e.EmployeeTypeId.ToString(),
                              DepartmentId = e.DepartmentId.ToString(),
                              DepartmentName = dept != null ? dept.Name : null,
                              CreatedDate = e.CreatedDate,
                              isDeleted = e.IsDeleted,
                              EmployeeTypeName = e.EmployeeType.Name != null ? e.EmployeeType.Name : null, 
                              EmployeeLabelVMs = e.EmployeeLabels.Select(el => new EmployeeLabelVM
                              {
                                  Id = el.Id.ToString(),
                                  Name = el.Name,
                              }).ToList(),
                              ShiftManagementVMs = e.ShiftManagements.Select(el => new ShiftManagementVM
                              {
                                  Id = el.Id.ToString(),
                                  Title = el.Title,
                              }).ToList(),
                              ApplicationSettingVMs = e.ApplicationSettings.Select(el => new ApplicationSettingVM
                              {
                                  Id = el.Id.ToString(),
                                  Name = el.Name,
                                  Code = el.Code,
                              }).ToList()
                          }).ToList();

            result.Skip(request.Page * request.Size).Take(request.Size).ToList();

            return Task.FromResult(new BringAllEmployeeResponse
            {
                TotalCount = totalCount,
                Employees = result
            });
        }
    }
}
