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
    public partial class Form_Maestro_Productos : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Maestro_Productos(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_añadir_Click(object sender, EventArgs e)
        {
            Form_Agregar_Producto agregar_Producto = new (EmpleadoActual, Database);
            agregar_Producto.Show();
            Hide();
            agregar_Producto.FormClosed += (s, args) => this.Show();
        }
    }
}
