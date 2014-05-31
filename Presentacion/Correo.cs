using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
namespace Presentacion
{
    class Correo
    {
        SmtpClient server = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("diguiliom@gmail.com", "algoritmos")
        };

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }
    }
}
