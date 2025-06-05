﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace EjemplosASPNET.Controllers
{
    public class ConfiguracionesController : Controller
    {
        private IConfiguration configuration;

        public ConfiguracionesController(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }
        public IActionResult Index()
        {
            // Ejemplo de manejo de appsettings.json

            var mensaje = configuration["Mensaje"];
            ViewBag.mensaje = mensaje;
            ViewBag.super1 = configuration["MisSuperConfiguraciones:Configuracion1"];
            ViewBag.super2 = configuration["MisSuperConfiguraciones:Configuracion2"];
            ViewBag.super3 = configuration["MisSuperConfiguraciones:Configuracion3"];
            ViewBag.level = configuration["Logging:LogLevel:Default"];
            return View();
        }
    }
}
