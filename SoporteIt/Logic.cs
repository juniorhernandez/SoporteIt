 using EASendMail;

namespace SoporteIt

    
{
    public class Logic
    {
        public string EnviarCorreo(string CorreoDestino,string Asunto)
        {
            String Mensaje = "Error al enviar correo.";

            try
            {
                SmtpMail ObjetoCorreo = new SmtpMail("TryId");

                ObjetoCorreo.From = "soporte.it.umg2022@gmail.com";
                ObjetoCorreo.To = CorreoDestino;
                ObjetoCorreo.Subject = Asunto;
                ObjetoCorreo.TextBody = "Uno de nuestros tecnicos se contactara contigo";

                SmtpServer ObjetoServidor = new SmtpServer("smtp.gmail.com");

                ObjetoServidor.User = "soporte.it.umg2022@gmail.com";
                ObjetoServidor.Password = "wpdmudzpmsuwbfqr";
                ObjetoServidor.Port = 587;
                ObjetoServidor.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient ObjetoCliente = new SmtpClient();
                ObjetoCliente.SendMail(ObjetoServidor, ObjetoCorreo);
                Mensaje = "Mensaje Enviado Correctamente ";
            }
            catch(Exception ex)
            {
                Mensaje = "Error al enviar mensaje. " + ex.Message;
            }
            return Mensaje;
        }

        
    }
}
