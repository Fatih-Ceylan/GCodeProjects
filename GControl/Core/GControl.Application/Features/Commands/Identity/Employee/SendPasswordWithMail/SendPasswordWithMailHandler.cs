using AutoMapper;
using GControl.Application.Abstractions.Mail;
using GControl.Application.Repositories.ReadRepository;
using GControl.Application.Repositories.WriteRepository;
using GControl.Application.VMs.Definitions;
using MediatR;
using System.Text;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.GControl.Definitions;

namespace GControl.Application.Features.Commands.Identity.Employee.SendPasswordWithMail
{

    public class SendPasswordWithMailHandler : IRequestHandler<SendPasswordWithMailRequest, SendPasswordWithMailResponse>
    {
        readonly IPasswordRemakeWriteRepository _passwordRemakeWriteRepository;
        readonly IPasswordRemakeReadRepository _passwordRemakeReadRepository;
        readonly IMailService _mailService;
        readonly IMapper _mapper;
        readonly IEmployeeReadRepository _employeeReadRepository;

        public SendPasswordWithMailHandler(IPasswordRemakeWriteRepository passwordRemakeWriteRepository, IMailService mailService, IMapper mapper, IPasswordRemakeReadRepository passwordRemakeReadRepository, IEmployeeReadRepository employeeReadRepository)
        {
            _passwordRemakeWriteRepository = passwordRemakeWriteRepository;
            _mailService = mailService;
            _mapper = mapper;
            _passwordRemakeReadRepository = passwordRemakeReadRepository;
            _employeeReadRepository = employeeReadRepository;
        }

        public async Task<SendPasswordWithMailResponse> Handle(SendPasswordWithMailRequest request, CancellationToken cancellationToken)
        {
            var existingEmail = _employeeReadRepository.GetByEmailAsync(request.Email).Result;

            if (existingEmail == null)
            {
                return new()
                {

                    StatusCode = "404"
                };
            };

            var verificationCode = GenerateRandomNumeric();

            T.PasswordRemake passwordRemake = _mapper.Map<T.PasswordRemake>(request);
            passwordRemake.CreatedDate = DateTime.Now;
            passwordRemake.Token = verificationCode;

            var passwordRemakeControl = _passwordRemakeReadRepository.GetByTokenAsync(passwordRemake.Token).Result;

            if (passwordRemakeControl != null)
            {
                 _passwordRemakeWriteRepository.HardDeleteById(passwordRemakeControl.Id.ToString());
            }

            passwordRemake = await _passwordRemakeWriteRepository.AddAsync(passwordRemake);

            await _passwordRemakeWriteRepository.SaveAsync();

            MailVM mailOption = new MailVM
            {
                To = new string[] { passwordRemake.Email },
                Subject = "Şifrenizi Yenileyin",
                Body = $@"
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Doğrulama Kodu</title>
</head>
<body>
    <div style='font-family: Arial, sans-serif; max-width: 600px; margin: 0 auto; padding: 20px;'>
        <h2>Doğrulama Kodu</h2>
        <p>Merhaba,</p>
        <p>Doğrulama kodunuz aşağıdadır:</p>
        <p style='font-size: 24px; font-weight: bold;'>{verificationCode}</p>
        <p>Bu kodu ilgili alana girerek işleminizi tamamlayabilirsiniz.</p>
        <p>Eğer bu isteği siz yapmadıysanız, bu e-postayı görmezden gelebilirsiniz.</p>
        <p>İyi günler dileriz.</p>
    </div>

    <!-- Resim en altta -->
    <div style='text-align: center; margin-top: 20px;'>
        <img src='https://example.com/images/company_logo.png' alt='Company Logo' style='max-width: 200px;'>
    </div>
</body>
</html>"
            };

            await _mailService.SendEMmailAsync(mailOption);

            var createdResponse = _mapper.Map<SendPasswordWithMailResponse>(passwordRemake);

            createdResponse.Message = CommandResponseMessage.AddedSuccess.ToString();
            createdResponse.StatusCode = "200";
            createdResponse.VerificationCode = passwordRemake.Token;
            return createdResponse;
        }

        private string GenerateRandomNumeric()
        {
            const string chars = "0123456789";
            Random random = new Random();
            StringBuilder builder = new StringBuilder(6);
            for (int i = 0; i < 6; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }
            return $"{builder.ToString()}";
        }
    }

}
