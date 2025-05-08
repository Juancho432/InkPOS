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
    public partial class Form_Busqueda_Factura : Form
    {
        public Form_Busqueda_Factura()
        {
            InitializeComponent();
        }

        private void txtbox_num_factura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_resultado_factura_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_ver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

      
            // Obtener los valores de los TextBox
            string num_factura = txtbox_num_factura.Text.Trim();

            int cantidad = factura.count(f => f == num_factura);
            //la factura que aparece como error es la tabla, se espera que busque en la DDBB y muestre la el resultado de la factura
            txtbox_resultado_factura.Text = cantidad.ToString();



        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            // Formulario para empleados
            Form_Home_Empleado homeEmpleado = new();
            homeEmpleado.Show();
        }
    }
}
