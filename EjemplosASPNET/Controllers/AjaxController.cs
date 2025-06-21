using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    [Route("ajax")] //http://localhost:5000/ajax
    public class AjaxController : Controller
    {
        [Route("")] //http://localhost:5000/ajax
        [Route("index")] //http://localhost:5000/ajax/index
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("ejemplo1")] //http://localhost:5000/ajax/ejemplo1
        public ContentResult Ejemplo1()
        {
            return Content("Desde el controlador AjaxController :D","text/plain");
        }
        [Route("ejemplo2/{nombre}")] //http://localhost:5000/ajax/ejemplo2/{nombre}
        public ContentResult Ejemplo2(string nombre)
        {
            return Content("Buenas noches "+ nombre + "!!!", "text/plain");
        }

        [Route("ejemplo3")] //http://localhost:5000/ajax/ejemplo3
        public IActionResult Ejemplo3()
        {
            var producto = new Producto()
            {
                Id = 1,
                Nombre = "Mapache",
                Precio = 1500.50,
                Foto = "uno.jpeg",
                Cantidad = 10
            };
            return new JsonResult(producto);
        }

        [Route("ejemplo4")] //http://localhost:5000/ajax/ejemplo4
        public IActionResult Ejemplo4()
        {
            var productos = new List<Producto>
            {
                new Producto(1, "Mapache", "uno.jpeg", 1500.50, 10),
                new Producto(2, "Perro", "dos.jpeg", 2000.00, 5),
                new Producto(3, "Gato", "tres.jpeg", 1800.75, 8)
            };
            return new JsonResult(productos);
        }

        // Ejemplo de jQuery UI
        [Produces("application/json")]
        public async Task<IActionResult> Ejemplo5()
        {
            string palabras = HttpContext.Request.Query["term"].ToString();

            // Conexion a DDBB
            // Recoleccion de resultados
            // var sugerencias = ProdDbContext.Productos.Where(p => p.Nombre.Contains(palabras)).Select(p => p.Nombre).ToListAsync();

            return Ok(); // Ok(sugerencias); // Retorna un JSON con las sugerencias
        }
    }
}
