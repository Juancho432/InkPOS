using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Modificar_Empleado : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Modificar_Empleado(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
