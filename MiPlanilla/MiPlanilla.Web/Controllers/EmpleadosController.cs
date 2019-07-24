using MiPlanilla.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPlanilla.Web.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            var empleadosBL = new EmpleadosBL();
            var listadeEmpleados = empleadosBL.ObtenerEmpleados();
        
            return View(listadeEmpleados);
        }
    }
}