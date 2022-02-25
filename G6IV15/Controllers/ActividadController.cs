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
        private static List<Actividad> _actividades = new List<Actividad>();
        public IActionResult Index()
        {
            ViewBag.Actividades = _actividades;
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(int ID, string Descripcion, int Estado)
        {
            var actividad = new Actividad();    
            actividad.ID = ID;
            actividad.Descripcion = Descripcion;
            actividad.Estado = Estado;
            _actividades.Add(actividad);
            return RedirectToAction("Index");
        }
    }
}
