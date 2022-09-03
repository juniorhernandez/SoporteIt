using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SoporteIt.herramientas
{
    public class EnviarCorreo
    {
        public void EnCorreo(String Direccion_DCorreo, String NumeroCaso, String Servicio)
        {
            try
            {
                Smtp Ec = new Smtp();
                MailMessage mensaje = new MailMessage();

                var numeroCaso = NumeroCaso;
                var servicio = Servicio;

                var asunto = "Caso " + " Creado";
                var remitente = "soporte.it.umg2022@gmail.com";
                var nombre = "Soporte de Casos IT";
                var cuerpo = "   Se creado su caso satisfactoriamente uno de nuestros especialistas de soporte técnico se estará comunicando contigo";

                mensaje.Subject = asunto;
                var Direccion_Correo = Direccion_DCorreo;

                mensaje.To.Add(new MailAddress(Direccion_Correo));
                

                mensaje.From = new MailAddress(remitente, nombre);

                mensaje.Body = cuerpo;

            
                Ec.MandarCorreo(mensaje);

             

                mensaje.Dispose();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
