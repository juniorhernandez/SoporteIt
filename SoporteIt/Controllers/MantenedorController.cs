using Microsoft.AspNetCore.Mvc;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;

using SoporteIt.Models;

using SoporteIt.herramientas;

namespace SoporteIt.Controllers
{
    public class MantenedorController : Controller
    {

        IFirebaseClient persona;

        public MantenedorController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "0s964tHgJpREYedbh5j7Cxd3FcTvOEr6UPq5L4sC",
                BasePath = "https://dbcasosit-default-rtdb.firebaseio.com/",

            };


            persona = new FirebaseClient(config);
        }
        public IActionResult crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult crear(Comentario oComentario)
        {
            string IdComentario = Guid.NewGuid().ToString("1");

            SetResponse response = persona.Set("Comentario/"+"Correo/" + IdComentario, oComentario);
         
            EnviarCorreo email = new EnviarCorreo();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string correo = Request.Form["Correo"].ToString();
                email.EnCorreo(correo ,"123","Base de Datos");
                return View();
            }
            else
            {
                return View();
            }

            
        }

    }
}
