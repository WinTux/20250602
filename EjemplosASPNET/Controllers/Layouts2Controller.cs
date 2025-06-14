using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class Layouts2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
