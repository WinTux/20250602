using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Models
{
    [Route("minimarket")]
    public class EjemploParaCarritoController : Controller
    {
        [Route("index")] // http://localhost:5000/minimarket/index
        [Route("")] // http://localhost:5000/minimarket
        public IActionResult Index()
        {
            ProductoModel prodModel = new ProductoModel();
            ViewBag.productos = prodModel.getTodo();
            return View();
        }
    }
}
