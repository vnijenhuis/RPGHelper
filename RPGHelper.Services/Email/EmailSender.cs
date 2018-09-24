using System;
using System.Threading.Tasks;

namespace RPGHelper.Services.Email
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }

        public Task SendSignupEmailASync()
        {
            throw new NotImplementedException();
        }

        public Task SendSignupDeniedAsync()
        {
            throw new NotImplementedException();
        }

        public Task SendSignupConfirmedAsync()
        {
            throw new NotImplementedException();
        }
    }
}
