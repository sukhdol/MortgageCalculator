using System.Net.Mail;

namespace MortgageCalculator.Models
{
    public class Email
    {
        private const string SenderEmail = "linusseven77@gmail.com";

        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void SendEmail()
        {
            var mail = new MailMessage();

            mail.To.Add(new MailAddress(RecipientEmail));
            mail.From = new MailAddress(SenderEmail);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            var smtpServer = new SmtpClient();

            smtpServer.Send(mail);
        }
    }
}