﻿namespace GControl.Application.VMs.Definitions
{
    public class MailVM 
    {
        public string[] To { get; set; }

        public string[]? CC { get; set; }

        public string[]? BCC { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; } = true;
    }
}
