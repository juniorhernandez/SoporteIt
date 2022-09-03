using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;


namespace SoporteIt.herramientas
{
    public class Smtp
    {
        SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

        public Smtp()
        {
            var usuario = "soporte.it.umg2022@gmail.com";
            var constrasena = "wpdmudzpmsuwbfqr";
            server.Credentials = new System.Net.NetworkCredential(usuario, constrasena);
            server.EnableSsl = true;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
            server.Dispose();

        }
    }
}
