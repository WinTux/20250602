using EjemplosASPNET.Conexion;
using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    [Route("EjemploDDBB")]
    public class EjemploDDBBController : Controller
    {
        private ProductoDbContext dbContext;

        public EjemploDDBBController(ProductoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.productos = dbContext.Productos.ToList();
            return View();
        }
        [Route("Editar/{id}")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var producto = dbContext.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound("Producto no encontrado");
            }
            return View("Editar", producto);
        }
        [Route("Editar2")]
        [HttpPost]
        public IActionResult Editar(Producto prod)
        {
            var producto = dbContext.Productos.FirstOrDefault(p => p.Id == prod.Id);
            if (producto == null)
            {
                return NotFound("Producto no encontrado");
            }
            producto.Nombre = prod.Nombre;
            producto.Foto = prod.Foto;
            producto.Precio = prod.Precio;
            producto.Cantidad = prod.Cantidad;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("Eliminar/{id}")]
        public IActionResult eliminar(int id)
        {
            var producto = dbContext.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound("Producto no encontrado");
            }
            dbContext.Productos.Remove(producto);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
