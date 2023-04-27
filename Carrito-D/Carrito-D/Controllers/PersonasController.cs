using Estacionamiento_D.Data;
using Estacionamiento_D.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamiento_D.Controllers
{
    public class PersonasController : Controller
    {
        private readonly MiBaseDeDatos _miBaseDeDatos;

        public PersonasController(MiBaseDeDatos miBase)
        {
            this._miBaseDeDatos = miBase;
        }


        public IActionResult Index()
        {

            var personas = _miBaseDeDatos.Personas;

            Persona persona = new Persona() {
                Nombre = "Pedro",
                Apellido="Picapiedra",
                Email = "pedro@picapiedra.com"
            };

            _miBaseDeDatos.Personas.Add(persona);


            Persona persona2 = new Persona()
            {
                Nombre = "Pablo",
                Apellido = "Marmol",
                Email = "pablo@marmol.com"
            };

            _miBaseDeDatos.Add(persona2);
            _miBaseDeDatos.SaveChanges();

            personas = _miBaseDeDatos.Personas;

            return View(personas);
        }
    }
}
