using EjemplosASPNET.Herramientas;
using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    public class SesionesController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("edad",60);
            HttpContext.Session.SetString("usuario", "Pepe");

            Producto pro = new Producto()
            {
                Id = 1,
                Nombre = "Queso natural",
                Precio = 22.5,
                Cantidad = 2,
                Foto = "queso.jpg"
            };
            ConversorSupremo.CsharpToJson(HttpContext.Session, pro, "productito");

            List<Producto> productos = new List<Producto>() {
                new Producto()
            {
                Id = 1,
                Nombre = "Queso natural",
                Precio = 22.5,
                Cantidad = 2,
                Foto = "queso.jpg"
            },
                new Producto()
            {
                Id = 2,
                Nombre = "Arroz",
                Precio = 11.5,
                Cantidad = 3,
                Foto = "arroz.jpg"
            },
                new Producto()
            {
                Id =3,
                Nombre = "Leche",
                Precio = 20.0,
                Cantidad = 12,
                Foto = "leche.webp"
            },
                new Producto()
            {
                Id = 4,
                Nombre = "Pan",
                Precio = 7.5,
                Cantidad = 2,
                Foto = "pan.jpeg"
            }
            };
            ConversorSupremo.CsharpToJson(HttpContext.Session, productos, "productos");
            return View();
        }
    }
}
