using System;

using System.Windows.Forms;

using System.Net.Mail;
using System.Net;

namespace Presentacion
{
    public static class Mailer
    {
        public static void SendMail(string MailFrom, string MailTo, string MailBody, string Password, string Subject)
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    MailMessage mail = new MailMessage();

                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(MailFrom);

                    mail.To.Add(MailTo);

                    mail.Subject = Subject;

                    mail.Body = MailBody;

                    SmtpServer.Port = 587;

                    SmtpServer.Credentials = new System.Net.NetworkCredential(MailFrom, Password);

                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);

                    MessageBox.Show("El mail ha sido enviado.");
                }
            }
            catch
            {
                MessageBox.Show("No ha sido posible enviar el email. Verifique la conexión a internet.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
