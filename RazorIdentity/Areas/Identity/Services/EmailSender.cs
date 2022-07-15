using System.Threading.Tasks;

namespace RazorIdentity.Areas.Identity.Services
{
    public class EmailSender : Microsoft.AspNetCore.Identity.UI.Services.IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
