using AutoMapper;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using GControl.Application.Abstractions.Mail;
using GControl.Application.Repositories.ReadRepository;
using GControl.Application.Repositories.WriteRepository;
using GControl.Application.VMs.Definitions;
using MediatR;
using System.Security.Cryptography;
using System.Text;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.GControl.Definitions;
namespace GControl.Application.Features.Commands.Definitions.Employee.EmployeeCredentials
{
    public class EmployeeCredentialsHandler : IRequestHandler<EmployeeCredentialsRequest, EmployeeCredentialsResponse>
    {
        readonly IEmployeeWriteRepository _employeeWriteRepository;
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IMapper _mapper;
        readonly IMailService _mailService;
        readonly ICompanyReadRepository _companyReadRepository;
        public EmployeeCredentialsHandler(IEmployeeReadRepository employeeReadRepository, IMapper mapper, IEmployeeWriteRepository employeeWriteRepository, IMailService mailService, ICompanyReadRepository companyReadRepository)
        {
            _employeeReadRepository = employeeReadRepository;
            _mapper = mapper;
            _employeeWriteRepository = employeeWriteRepository;
            _mailService = mailService;
            _companyReadRepository = companyReadRepository;
        }
        public async Task<EmployeeCredentialsResponse> Handle(EmployeeCredentialsRequest request, CancellationToken cancellationToken)
        {
            var employee = await _employeeReadRepository.GetByIdAsync(request.Id);
            var Employee = _mapper.Map<T.Employee>(employee);

            var newPassword = GenerateRandomPassword(6);
            Employee.Password = HashPassword(newPassword);

            var createdResponse = _mapper.Map<EmployeeCredentialsResponse>(Employee);

            Employee = _mapper.Map(request, Employee);

            await _employeeWriteRepository.SaveAsync();

            createdResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();
            var companyDetail = _companyReadRepository.GetAllDeletedStatusDesc(false);
            var matchingCompany = companyDetail.FirstOrDefault(c => c.Id == Guid.Parse(employee.CompanyId.ToString()));
            string logoPath = null; // Default path if no match is found
            string ipAddress = "http://10.0.96:90/";
            if (matchingCompany != null && !string.IsNullOrEmpty(matchingCompany.LogoPath))
            {
                logoPath = matchingCompany.LogoPath; // Use the LogoPath from matched company detail
            }
            string path = logoPath != null ? $"{ipAddress}{logoPath}" : null;

            // Prepare the email body
            string emailBody = $@"
            <html>
                <body>
                    <table align='center' style='width: 100%; text-align: center;'>
                        <tr>
                            <td>
                                {(path != null ? $"<img src='{path}' alt='Company Logo' style='display: block; margin-left: auto; margin-right: auto;' height='40' />" : "")}
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
                                        <td>{newPassword}</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </body>
            </html>";

            var mailCredantial = new MailVM
            {
                To = new string[] { employee.Email },
                Subject = "GControl Hesap Bilgileriniz",
                Body = emailBody,
                IsBodyHtml = true
            };

            await _mailService.SendEMmailAsync(mailCredantial);
            return createdResponse;
        }

        private string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            while (0 < length--)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }
            return password.ToString();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

