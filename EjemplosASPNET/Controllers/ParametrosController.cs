using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    [Route("param")] // http://localhost:5194/param
    public class ParametrosController : Controller
    {
        [Route("i")] // http://localhost:5194/param/i
        [Route("index")] // http://localhost:5194/param/index
        [Route("~/")] // http://localhost:5194/param/
        public IActionResult Index()
        {
            return View();
        }
        [Route("Ejemplo2/{nom}")] // http://localhost:5194/param/ej2/Pepe
        public IActionResult Ejemplo2(string nom)
        {
            // El parámetro nom se puede usar en la vista
            ViewBag.Nombre = nom;
            return View("UsoDeParametros");
        }
        [Route("Ejemplo3/{nom}/edad/{edad}")] // http://localhost:5194/param/ej2/Pepe
        public IActionResult Ejemplo3(string nom, int edad)
        {
            // El parámetro nom se puede usar en la vista
            ViewBag.Nombre = nom;
            ViewBag.Edad = edad;
            return View("UsoDeParametros");
        }
        [Route("ej4")]
        public IActionResult Ejemplo4([FromQuery(Name = "nom")] string nombre){
            ViewBag.Nombre = nombre + " (Usando QueryStrings)";
            return View("UsoDeParametros");
        }

        [Route("ej5")]
        public IActionResult Ejemplo5([FromQuery(Name = "nom")] string nombre, [FromQuery(Name = "edad")] int edad)
        {
            ViewBag.Nombre = nombre + " (Usando QueryStrings)";
            ViewBag.Edad = edad + " (Usando QueryStrings)";
            return View("UsoDeParametros");
        }
    }
}
