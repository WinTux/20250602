using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjemplosASPNET.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            var cuentaParaView = new CuentaParaView();
            cuentaParaView.Cuenta = new Cuenta() { 
                Id = 123,
                Disponible = true,
                Genero = "M"
            };
            cuentaParaView.Lenguajes = new List<Lenguaje>()
            {
                new Lenguaje() { Id = "len01", Nombre = "C#", Tickeado=true },
                new Lenguaje() { Id = "len02", Nombre = "Java", Tickeado=false },
                new Lenguaje() { Id = "len03", Nombre = "Python", Tickeado=true },
                new Lenguaje() { Id = "len04", Nombre = "JavaScript", Tickeado=false },
                new Lenguaje() { Id = "len05", Nombre = "PHP", Tickeado=false },
                new Lenguaje() { Id = "len06", Nombre = "Ruby", Tickeado=false },
                new Lenguaje() { Id = "len07", Nombre = "Go", Tickeado=false },
                new Lenguaje() { Id = "len08", Nombre = "Swift", Tickeado=true },
                new Lenguaje() { Id = "len09", Nombre = "Kotlin", Tickeado=false }
            };
            var cargos = new List<Cargo>() { 
                new Cargo() { Id = "c01", Nombre = "Gerente" },
                new Cargo() { Id = "c02", Nombre = "Administrador" },
                new Cargo() { Id = "c03", Nombre = "Programador" },
                new Cargo() { Id = "c04", Nombre = "Tester" }
            };
            cuentaParaView.Cargos = new SelectList(cargos, "Id", "Nombre", "c03"); // c01, c03 // Gerente, Administrador, Programador, Tester
            return View("Index", cuentaParaView);
        }

        [HttpPost] // http://localhost:5194/formulario/registrar [POST]
        public IActionResult Registrar(CuentaParaView cuentaParaView, List<Lenguaje> lenguajes) {
            cuentaParaView.Cuenta.Lenguajes = new List<string>();
            foreach (var lenguaje in lenguajes)
                if (lenguaje.Tickeado)
                    cuentaParaView.Cuenta.Lenguajes.Add(lenguaje.Id);
            ViewBag.Cuenta = cuentaParaView.Cuenta;
            return View("Registrado");
        }
    }
}
