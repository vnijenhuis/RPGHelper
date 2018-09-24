using System.Threading.Tasks;

namespace RPGHelper.Services.Email
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendSignupEmailASync();
        Task SendSignupDeniedAsync();
        Task SendSignupConfirmedAsync();
    }
}
