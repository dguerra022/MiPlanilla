using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlanilla.BL
{
    public class EmpleadosBL
    {
        public List<Empleado> ObtenerEmpleados()
        {
            var empleado1 = new Empleado();
            empleado1.Id = 1;
            empleado1.Nombre = "Juan Perez";
            empleado1.Salario = 12000;

            var empleado2 = new Empleado();
            empleado2.Id = 2;
            empleado2.Nombre = "J. Pertino";
            empleado2.Salario = 10000;

            var empleado3 = new Empleado();
            empleado3.Id = 3;
            empleado3.Nombre = "Miguel Aleman";
            empleado3.Salario = 13000;

            var listadeEmpleados = new List<Empleado>();
            listadeEmpleados.Add(empleado1);
            listadeEmpleados.Add(empleado2);
            listadeEmpleados.Add(empleado3);

            return listadeEmpleados;
        }
       
    }
}
