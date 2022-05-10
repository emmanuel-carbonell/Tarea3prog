using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea3prog.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;



namespace Tarea3prog.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Inicio()
        {
            return View();
        }




        public ActionResult Datos()
        {

            return View();
        }


        public ActionResult Resultados(Empleado data)
        {
            var manejoarchivo = ManejoArchivo.GetInstance;

            manejoarchivo.Guardar(data);

            return View(data);

        }
    }
}