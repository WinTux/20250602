using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    // http://localhost:8080/Prueba
    public class PruebaController : Controller
    {
        // http://localhost:8080/Prueba/Index
        public IActionResult Index()
        {
            /* Ejemplo de archivos estáticos
             +++++++++++++++++++++++++++++++
            
             CSS, JavaScript e imágenes
            */
            return View();
        }
        // http://localhost:8080/Prueba/PasandoDatos
        public IActionResult PasandoDatos()
        {
            ViewBag.edad = 20;
            ViewBag.nombre = "Pepe Perales";
            ViewBag.casado = true;
            ViewBag.peso = 75.5;
            ViewBag.fechaNacimiento = new DateTime(2005, 7, 30);
            return View();
        }

        // http://localhost:8080/Prueba/PasandoObjetos
        public IActionResult PasandoObjetos()
        {
            Producto producto = new Producto()
            {
                Id = 1,
                Nombre = "Queso de lata",
                Foto = "queso.jpg",
                Precio = 19.0,
                Cantidad = 12
            };
            ViewBag.producto = producto;
            return View("PasandoDatos");
        }
        // http://localhost:8080/Prueba/PasandoListaObjetos
        public IActionResult PasandoListaObjetos()
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto(1, "Queso de lata", "queso.jpg", 19.0, 12),
                new Producto(2, "Leche de cabra", "leche.webp", 15.0, 20),
                new Producto(3, "Pan de ajo", "pan.jpeg", 10.0, 30)
            };
            ViewBag.productos = productos;
            return View("PasandoDatos");
        }
    }
}
