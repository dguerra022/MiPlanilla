using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlanilla.BL
{
    public class EmpleadosBL
    {
        Contexto _contexto;
        public List<Empleado> ListadeEMpleados { get; set; }

        public EmpleadosBL()
        {
            _contexto = new Contexto();
            ListadeEMpleados = new List<Empleado>();
        }
        public List<Empleado> ObtenerEmpleados()
        {
            ListadeEMpleados = _contexto.Empleados.ToList();
            return ListadeEMpleados;
        }
       
    }
}
