using EjemplosASPNET.Herramientas;
using EjemplosASPNET.Models;
using EjemplosASPNET.Models.ParaCarrito;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Agregar/{id}")]
        public IActionResult Agregar(string id) {
            ProductoModel productoModel = new ProductoModel();
            if (ConversorSupremo.JsonToCsharp<List<Item>>(HttpContext.Session, "carrito") == null)
            {
                List<Item> carrito = new List<Item>();
                carrito.Add(new Item { Producto = productoModel.getById(id), Cantidad = 1 });
                ConversorSupremo.CsharpToJson(HttpContext.Session, carrito, "carrito");
            }
            else { // Ya existe el carrito en sesión:
                // ¿agregará un producto nuevo o agregará un producto que ya existe?
                List<Item> carrito = ConversorSupremo.JsonToCsharp<List<Item>>(HttpContext.Session, "carrito");
                int indice = existe(id); // si no existe es -1
                if (indice != -1)
                    carrito[indice].Cantidad++;
                else
                    carrito.Add(new Item { Producto = productoModel.getById(id), Cantidad = 1 });
                ConversorSupremo.CsharpToJson(HttpContext.Session, carrito, "carrito");
            }
            return RedirectToAction("Index");
        }
        [NonAction]
        private int existe(string id)
        {
            List<Item> carrito = ConversorSupremo.JsonToCsharp<List<Item>>(HttpContext.Session, "carrito");
            for (int i = 0; i < carrito.Count; i++)
                if (carrito[i].Producto.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}
