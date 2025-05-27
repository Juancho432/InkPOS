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
    public partial class Form_Personalizacion_Factura : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Personalizacion_Factura(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();

        }

        private void Form_Personalizacion_Factura_Load(object sender, EventArgs e)
        {
            lbl_upload.Visible = false;
            button_upload.Visible = false;
        }

        private void CB_valor_a_modificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_valor_a_modificar.SelectedItem != null && CB_valor_a_modificar.SelectedItem.ToString() == "Logo")
            {
                // Mostrar controles para subir logo
                lbl_upload.Visible = true;
                button_upload.Visible = true;

                // Ocultar controles de texto
                lbl_ingresevalor.Visible = false;
                txtbox_nuevo_valor.Visible = false;
            }
            else
            {
                // Ocultar controles de subir logo
                lbl_upload.Visible = false;
                button_upload.Visible = false;

                // Mostrar controles de texto
                lbl_ingresevalor.Visible = true;
                txtbox_nuevo_valor.Visible = true;
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
