using AutoMapper;
using GControl.Application.Abstractions.Mail;
using GControl.Application.Repositories.ReadRepository;
using GControl.Application.Repositories.WriteRepository;
using GControl.Application.VMs.Definitions;
using MediatR;
using System.Security.Cryptography;
using System.Text;
using Utilities.Core.UtilityApplication.Abstractions.Storage;
using Utilities.Core.UtilityApplication.Enums;
using F = BaseProject.Domain.Entities.GControl.Definitions;
using T = BaseProject.Domain.Entities.GControl.Definitions.Files;
namespace GControl.Application.Features.Commands.Definitions.Employee.Create
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeRequest, CreateEmployeeResponse>
    {
        readonly IEmployeeWriteRepository _EmployeeWriteRepository;
        readonly IEmployeeReadRepository _EmployeeReadRepository;
        readonly IEmployeeLabelWriteRepository _EmployeeLabelWriteRepository;
        readonly IEmployeeLabelReadRepository _EmployeeLabelReadRepository;
        readonly IShiftManagementReadRepository _ShiftManagementReadRepository;
        readonly IShiftManagementWriteRepository _ShiftManagementWriteRepository;
        readonly IApplicationSettingReadRepository _ApplicationSettingReadRepository;
        readonly IMapper _mapper;
        readonly IStorageService _storageService;
        readonly IEmployeeFileWriteRepository _EmployeeFileWriteRepository;
        readonly BaseProject.Application.Repositories.ReadRepository.Definitions.ICompanyReadRepository _companyReadRepository;
        readonly IMailService _mailService;
        public CreateEmployeeHandler(IEmployeeWriteRepository EmployeeWriteRepository, IMapper mapper, IEmployeeReadRepository employeeReadRepository, IEmployeeLabelWriteRepository employeeLabelWriteRepository, IEmployeeLabelReadRepository employeeLabelReadRepository, IShiftManagementWriteRepository shiftManagementWriteRepository, IShiftManagementReadRepository shiftManagementReadRepository, IStorageService storageService, IEmployeeFileWriteRepository employeeFileWriteRepository, IApplicationSettingReadRepository applicationSettingReadRepository, BaseProject.Application.Repositories.ReadRepository.Definitions.ICompanyReadRepository companyReadRepository, IMailService mailService)
        {
            _EmployeeWriteRepository = EmployeeWriteRepository;
            _mapper = mapper;
            _EmployeeReadRepository = employeeReadRepository;
            _EmployeeLabelWriteRepository = employeeLabelWriteRepository;
            _EmployeeLabelReadRepository = employeeLabelReadRepository;
            _ShiftManagementWriteRepository = shiftManagementWriteRepository;
            _ShiftManagementReadRepository = shiftManagementReadRepository;

            _storageService = storageService;
            _EmployeeFileWriteRepository = employeeFileWriteRepository;
            _ApplicationSettingReadRepository = applicationSettingReadRepository;
            _companyReadRepository = companyReadRepository;
            _mailService = mailService;
        }
        public async Task<CreateEmployeeResponse> Handle(CreateEmployeeRequest request, CancellationToken cancellationToken)
        {
            if (request.CompanyId == "SelectAll")
            {
                request.CompanyId = null;
            }
            var employee = _mapper.Map<F.Employee>(request);
            if (string.IsNullOrEmpty(request.CompanyId) || request.CompanyId == "SelectAll")
            {
                var mainCompanyId = _companyReadRepository.GetWhere(x => x.MainCompanyId == null).FirstOrDefault().Id;
                employee.CompanyId = mainCompanyId;
            }
            if (_EmployeeWriteRepository.GetWhere(e => e.UserName == employee.UserName).Any())
            {
                var random = new Random();
                var suffix = random.Next(1000); // Rastgele bir sayı üretin (örneğin, 0 ile 999 arası)

                // İstenen kullanıcı adını kontrol edin
                while (_EmployeeWriteRepository.GetWhere(e => e.UserName == employee.UserName + suffix).Any())
                {
                    // Eğer mevcutsa, rastgele sayıyı kullanıcı adına ekle ve tekrar kontrol edin
                    suffix = random.Next(1000); // Yeni bir rastgele sayı alın
                }

                employee.UserName = $"{employee.UserName}{suffix}";
            }
            
            if (request.EmployeeLabelsId.Count > 0)
            {
                foreach (var employeeLabelId in request.EmployeeLabelsId)
                {
                    var employeeLabel = await _EmployeeLabelReadRepository.GetByIdAsync(employeeLabelId);

                    if (employeeLabel != null)
                    {
                        employee.EmployeeLabels.Add(employeeLabel);
                    }
                }
            }
            if (request.ShiftManagementsId.Count > 0)
            {
                foreach (var shiftManagementId in request.ShiftManagementsId)
                {
                    var shiftManagement = await _ShiftManagementReadRepository.GetByIdAsync(shiftManagementId);

                    if (shiftManagement != null)
                    {
                        employee.ShiftManagements.Add(shiftManagement);
                    }
                }
            }

            if (request.ApplicationSettingsId.Count > 0)
            {
                foreach (var applicationSettingsId in request.ApplicationSettingsId)
                {
                    var applicationSetting = await _ApplicationSettingReadRepository.GetByIdAsync(applicationSettingsId);

                    if (applicationSetting != null)
                    {
                        employee.ApplicationSettings.Add(applicationSetting);
                    }
                }
            }


            List<(string fileName, string pathOrContainerName)>? uploadedDatas = null;
            if (request.Files.Count > 0)
                uploadedDatas = await _storageService.UploadAsync("Employee-ProfilePictures", request.Files);

            employee.ProfilePicturePath = uploadedDatas != null ? uploadedDatas.Select(t => t.pathOrContainerName).FirstOrDefault() : null;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(request.Password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                employee.Password = builder.ToString();
            }

            employee = await _EmployeeWriteRepository.AddAsync(employee);
            if (uploadedDatas != null)
            {
                await _EmployeeFileWriteRepository.AddRangeAsync(uploadedDatas.Select(r => new T.EmployeeFile()
                {
                    FileName = r.fileName,
                    Path = r.pathOrContainerName,
                    Storage = _storageService.StorageName,
                    Employees = new List<F.Employee>() { employee }
                }).ToList());
            }
            var createdResponse = _mapper.Map<CreateEmployeeResponse>(employee);

            if (request.EmployeeLabelsId.Count > 0)
            {
                var employeeLabelList = _EmployeeLabelReadRepository
                           .GetAllDeletedStatusDesc(false)
                           .Where(d => request.EmployeeLabelsId.Contains(d.Id.ToString()))
                           .Select(d => new EmployeeLabelVM
                           {
                               Id = d.Id.ToString(),
                               Name = d.Name,
                               CreatedDate = d.CreatedDate,
                           }).ToList();

                createdResponse.EmployeeLabelsId = employeeLabelList;
            }


            if (request.ShiftManagementsId.Count > 0)
            {
                var shiftManagementList = _ShiftManagementReadRepository
                           .GetAllDeletedStatusDesc(false)
                           .Where(d => request.ShiftManagementsId.Contains(d.Id.ToString()))
                           .Select(d => new ShiftManagementVM
                           {
                               Id = d.Id.ToString(),
                               Title = d.Title,
                               CreatedDate = d.CreatedDate,
                           }).ToList();

                createdResponse.ShiftManagementsId = shiftManagementList;
            }

            if (request.ApplicationSettingsId.Count > 0)
            {
                var applicationSettingsList = _ApplicationSettingReadRepository
                           .GetAllDeletedStatusDesc(false)
                           .Where(d => request.ApplicationSettingsId.Contains(d.Id.ToString()))
                           .Select(d => new ApplicationSettingVM
                           {
                               Id = d.Id.ToString(),
                               Name = d.Name,
                               CreatedDate = d.CreatedDate,
                           }).ToList();

                createdResponse.ApplicationSettingsId = applicationSettingsList;
            }
            await _EmployeeWriteRepository.SaveAsync();
            createdResponse.Message = CommandResponseMessage.AddedSuccess.ToString();

            var companyDetail = _companyReadRepository.GetAllDeletedStatusDesc(false);
            var matchingCompany = companyDetail.FirstOrDefault(c => c.Id == Guid.Parse(request.CompanyId));
            string logoPath = null; // Default path if no match is found
            string ipAddress = "http://10.0.96:90/";
            if (matchingCompany != null && !string.IsNullOrEmpty(matchingCompany.LogoPath))
            {
                logoPath = matchingCompany.LogoPath; // Use the LogoPath from matched company detail
            }
            string path = logoPath != null ? $"{ipAddress}{logoPath}" : null;

            string emailBody = $@"
            <html>
                <body>
                    <table align='center' style='width: 100%; text-align: center;'>
                        <tr>
                            <td>
                                {(path != null ? $"<img src='{path}' alt='Company Logo' style='display: block; margin-left: auto; margin-right: auto;' height= '40' />" : "")}
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table align='center' border='1' cellpadding='10' cellspacing='0' style='width: 50%; margin-top: 20px;'>
                                    <tr>
                                        <th align='left'>Email</th>
                                        <td>{employee.Email}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Kullanıcı Adı</th>
                                        <td>{employee.UserName}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Şifre</th>
                                        <td>{request.Password}</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </body>
            </html>";

            var mailCredantial = new MailVM
            {
                To = new string[] { request.Email },
                Subject = "GControl Hesap Bilgileriniz",
                Body =emailBody,
                IsBodyHtml = true
            };

            await _mailService.SendEMmailAsync(mailCredantial);

            return createdResponse;
        }
    }
}

