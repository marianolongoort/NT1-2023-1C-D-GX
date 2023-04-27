using Estacionamiento_D.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Estacionamiento_D.Controllers
{
    public class HomeController : Controller
    {       
        public ActionResult Index(string nombre,string apellido)
        {
            Persona persona = new Persona() { 
                Apellido = apellido,
                Nombre = nombre
            };

            ViewResult result = View(persona);

            return result;
        }

        private ActionResult Nombres(int? personaId,string nombre,string apellido = "No definido") 
        {         
            if(personaId == null)
            {
                return Content($"{nombre},{apellido}");
            }
            else
            {
                return Content($"{nombre},{apellido} y el numero es {personaId}");
            }
            
        }

        public ActionResult Privacy()
        {
            return View();
        }

    }
}