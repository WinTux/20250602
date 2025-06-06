using EjemplosASPNET.Models;
using Microsoft.AspNetCore.Mvc;

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
                new Lenguaje() { Id = "len01", Nombre = "C#" },
                new Lenguaje() { Id = "len02", Nombre = "Java" },
                new Lenguaje() { Id = "len03", Nombre = "Python" },
                new Lenguaje() { Id = "len04", Nombre = "JavaScript" },
                new Lenguaje() { Id = "len05", Nombre = "PHP" },
                new Lenguaje() { Id = "len06", Nombre = "Ruby" },
                new Lenguaje() { Id = "len07", Nombre = "Go" },
                new Lenguaje() { Id = "len08", Nombre = "Swift" },
                new Lenguaje() { Id = "len09", Nombre = "Kotlin" }
            };
            var cargos = new List<Cargo>() { 
                new Cargo() { Id = "c01", Nombre = "Gerente" },
                new Cargo() { Id = "c02", Nombre = "Administrador" },
                new Cargo() { Id = "c03", Nombre = "Programador" },
                new Cargo() { Id = "c04", Nombre = "Tester" }
            };
            return View("Index", cuentaParaView);
        }
    }
}
