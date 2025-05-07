using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace InkPos
{
    public partial class Form_Home_Admin : Form
    {
        public Form_Home_Admin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_BP_CS_AP busqueda_Productos = new Form_BP_CS_AP();
            busqueda_Productos.Show();
            this.Hide(); // Oculta Form1 en lugar de cerrarlo
            busqueda_Productos.FormClosed += (s, args) => this.Show();
        }

        private void button_maestro_productos_Click(object sender, EventArgs e)
        {
            Form_home_maestro_productos seleccion_Maestro_Productos = new Form_home_maestro_productos();
            seleccion_Maestro_Productos.Show();
            this.Hide();
            seleccion_Maestro_Productos.FormClosed += (s, args) => this.Show();
        }

        private void button_gestion_empleados_Click(object sender, EventArgs e)
        {
            Form_Gestion_Empleados gestion_Empleados = new Form_Gestion_Empleados();
            gestion_Empleados.Show();
            this.Hide(); 
            gestion_Empleados.FormClosed += (s, args) => this.Show();
        }

        private void button_facturas_Click(object sender, EventArgs e)
        {
            Form_Busqueda_Factura busqueda_Factura = new Form_Busqueda_Factura();
            busqueda_Factura.Show();
            this.Hide(); 
            busqueda_Factura.FormClosed += (s, args) => this.Show();
        }
    }
}
