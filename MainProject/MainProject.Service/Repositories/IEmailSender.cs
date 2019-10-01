using System.Threading.Tasks;

namespace MainProject.Service
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
