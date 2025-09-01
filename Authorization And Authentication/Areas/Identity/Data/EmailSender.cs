using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    private readonly string _gmail = "affanahme@gmail.com";
    private readonly string _password = "ymur istr vsvm ahdw"; // App Password, not your real password

    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential(_gmail, _password),
            EnableSsl = true
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_gmail),
            Subject = subject,
            Body = htmlMessage,
            IsBodyHtml = true
        };

        mailMessage.To.Add(email);

        return client.SendMailAsync(mailMessage);
    }
}
