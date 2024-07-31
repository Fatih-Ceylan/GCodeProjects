using GCard.Application.VMs;

namespace GCard.Application.Abstractions.Mail
{
    public interface IMailService
    {
        Task SendEMmailAsync(MailVM mailOption);
    }
}
