﻿namespace Utilities.Core.UtilityApplication.DTOs.Mail
{
    public class MailCredantialDTO
    {
        public string From { get; set; }

        public string FromPassword { get; set; }

        public string DisplayName { get; set; }

        public int Port { get; set; }

        public string Host { get; set; }

        public bool EnableSsl { get; set; } = true;
    }
}
