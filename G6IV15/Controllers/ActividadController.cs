//1.- Agregar las librerias/ensamblados necesarias
using Microsoft.AspNetCore.Mvc;
using System;
using G6IV15.Models;
using System.Collections.Generic;

namespace G6IV15.Controllers
{
    public class ActividadController : Controller
    {
        //Una instancia privada de tipo Lista, que va almacenar
        //objetos de tipo Actividad
        private List<Actividad> _actividades = new List<Actividad>();
        public IActionResult Index()
        {
            ViewBag.Actividades = _actividades;
            return View();
        }
    }
}
