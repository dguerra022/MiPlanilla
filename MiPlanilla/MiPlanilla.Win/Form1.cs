using MiPlanilla.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPlanilla.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var empleadosBL = new EmpleadosBL();
            var listadeEmpleados = empleadosBL.ObtenerEmpleados();

            listadeEMpleadosBindingSource.DataSource = listadeEmpleados;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
