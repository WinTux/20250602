using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemplosASPNET.Controllers
{
    [Route("producto")]
    public class ProductoController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;

        public ProductoController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        [Route("")] // https://localhost:5001/producto
        [Route("index")] // https://localhost:5001/producto/index
        public IActionResult Index()
        {
            return View("Index", new Producto());
        }
        [HttpPost]
        public IActionResult Registrar(Producto producto, IFormFile[] imagenes)
        {
            if (imagenes != null && imagenes.Length > 0)
            {
                // Guardar la imagen en el servidor
                foreach (var imagen in imagenes)
                {
                    if (imagen.Length > 0)
                    {
                        // Crear la ruta donde se guardará la imagen
                        var ruta = Path.Combine(webHostEnvironment.WebRootPath, "imagenes", imagen.FileName);
                        // Guardar la imagen en la ruta especificada
                        using (var stream = new FileStream(ruta, FileMode.Create))
                        {
                            imagen.CopyToAsync(stream);
                        }
                    }
                }
                producto.Foto = imagenes[0].FileName; // Asignar el nombre de la imagen al producto
                ViewBag.prod = producto; // Pasar el producto a la vista
                ViewBag.fotos = imagenes;
            }
            else
                return Content("Imagenes necesarias; vuelva a interlo.");
            return View("Registrado");
        }
    }
}
