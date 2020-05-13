using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace SpringBlog.Helpers
{
    public static class EmailUtilities
    {
        public static async Task SendMailAsync(string destination, string subject, string body)
        {
            //http://csharp.net-informations.com/communications/csharp-smtp-mail.htm
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("info@bekoo.co");
            mail.To.Add(destination);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            using (var smtpClient = new SmtpClient("bekoo.co"))
            {
                await smtpClient.SendMailAsync(mail);
            }

        }
    }
}