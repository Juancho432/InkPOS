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
    public partial class Form_Devolucion : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        public Form_Devolucion(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
