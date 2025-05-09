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
    public partial class Form_home_maestro_productos : Form
    {

        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        public Form_home_maestro_productos(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_venta_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_Agregar_producto agregar_Producto = new Form_Agregar_producto();
            agregar_Producto.Show();
            this.Hide();
            agregar_Producto.FormClosed += (s, args) => this.Show();
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            //modificar_producto modificar_Producto = new();
            //modificar_Producto.Show();
            //this.Hide();
            //modificar_Producto.FormClosed += (s, args) => this.Show();
        }
    }
}
