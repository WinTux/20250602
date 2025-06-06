using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjemplosASPNET.Models
{
    public class CuentaParaView
    {
        public Cuenta Cuenta { get; set; }
        public List<Lenguaje> Lenguajes { get; set; } // len01, len02
        public SelectList Cargos { get; set; } // c01, c03 // Gerente, Administrador, Programador, Tester
    }
}
