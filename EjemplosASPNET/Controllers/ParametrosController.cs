using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    [Route("param")] // http://localhost:5194/param
    public class ParametrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("ej2")]
        public IActionResult Ejemplo2()
        {
            return View();
        }
    }
}
