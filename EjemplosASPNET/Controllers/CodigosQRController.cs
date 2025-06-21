using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class CodigosQRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Generar(string texto)
        {
            ViewBag.mensaje = texto;
            return View("Index");
        }
    }
}
