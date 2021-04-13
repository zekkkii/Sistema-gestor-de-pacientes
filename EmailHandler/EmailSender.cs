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
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("noreplay.gestorpacientes@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = 465;
                smtpServer.Credentials = new NetworkCredential("noreplay.gestorpacientes@gmail.com", "#Querty123");
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
