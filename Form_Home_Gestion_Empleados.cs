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
    public partial class Form_Home_Gestion_Empleados : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Home_Gestion_Empleados(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_añadir_Click(object sender, EventArgs e)
        {
            Form_Agregar_Empleado agregar_empleado = new(EmpleadoActual, Database);
            agregar_empleado.Show();
            Hide();
            agregar_empleado.FormClosed += (s, args) => this.Show();
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Form_Modificar_Empleado modificar_empleado = new(EmpleadoActual, Database);
            modificar_empleado.Show();
            Hide();
            modificar_empleado.FormClosed += (s, args) => this.Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
