using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailHandler
{
    public class EmailSender
    {
        public bool sendEmail(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient(EmailSettings.Default.SmtpServer);

                mail.From = new MailAddress(EmailSettings.Default.From);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

<<<<<<< HEAD
                smtpServer.Port = EmailSettings.Default.Port;
                smtpServer.Credentials = new NetworkCredential(EmailSettings.Default.From, EmailSettings.Default.Password);
=======
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("noreplay.gestorpacientes@gmail.com", "#Querty123");
>>>>>>> fda47849fffc958000428e716186262c5d67a63b
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);



                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
