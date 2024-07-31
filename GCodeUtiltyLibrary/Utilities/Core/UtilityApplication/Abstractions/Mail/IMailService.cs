using Utilities.Core.UtilityApplication.DTOs.Mail;

namespace Utilities.Core.UtilityApplication.Abstractions.Mail
{
    public interface IMailService
    {
        Task<string> SendEMmailAsync(MailCredantialDTO mailCredantial, MailOptionDTO mailOption);

        Task<MailCredantialDTO> GetStaticMailCredantial();
    }
}