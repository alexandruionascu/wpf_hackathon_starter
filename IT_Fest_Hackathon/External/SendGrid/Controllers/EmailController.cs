using IT_Fest_Hackathon.External.SendGrid.Models;
using SendGrid;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace IT_Fest_Hackathon.Domain.SendGrid
{
    public class EmailController
    {
        public async Task sendEmail(string subject, string message, string senderName, string senderEmail, params string[] recipientEmails)
        {
            var email = new SendGridMessage()
            {
                Subject = subject,
                Text = message,
                From = new MailAddress(senderEmail, senderName)
            };

            email.AddTo(recipientEmails);

            var credentials = new NetworkCredential(SendGridCredentials.username, SendGridCredentials.password);

            await new Web(credentials).DeliverAsync(email);
        }
    }
}
