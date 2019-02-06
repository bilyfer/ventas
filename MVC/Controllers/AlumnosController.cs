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

            return View(alumno);
        }
    }
}