using EjemplosASPNET.Conexion;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class EjemploDDBBController : Controller
    {
        private ProductoDbContext dbContext;

        public EjemploDDBBController(ProductoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.productos = dbContext.Productos.ToList();
            return View();
        }
    }
}
