using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Service
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
