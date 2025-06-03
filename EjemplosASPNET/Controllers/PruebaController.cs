using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
