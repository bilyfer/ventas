using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            var alumno = new Alumno();
            alumno.Id = 1;
            alumno.Nombre = "Steve Rogers";
            alumno.Telefono = "5555";
            alumno.Direccion = "alguna direccion";

            return View(alumno);
        }

        public ActionResult Lista()
        {
            var alumno1 = new Alumno();
            alumno1.Id = 2;
            alumno1.Nombre = "Thor";

            var alumno2 = new Alumno();
            alumno2.Id = 3;
            alumno2.Nombre = "Ironman";

            var listaAlumnos = new List<Alumno>();
            listaAlumnos.Add(alumno1);
            listaAlumnos.Add(alumno2);

            return View(listaAlumnos);
        }
    }
}