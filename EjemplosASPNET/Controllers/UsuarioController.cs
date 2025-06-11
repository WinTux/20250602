using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", new Usuario());
        }
        [HttpPost]
        public IActionResult Guardar(Usuario u) {
            if (ModelState.IsValid) {
                ViewBag.usuario = u;
                return View("Exito");
            } else
                return View("Index");
        }
    }
}
