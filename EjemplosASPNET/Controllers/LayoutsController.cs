using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class LayoutsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Acerca1()
        {
            return View();
        }
    }
}
