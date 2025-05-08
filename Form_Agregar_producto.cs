using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Agregar_producto : Form
    {
        public agregar_producto()
        {
            InitializeComponent();
        }

        // Evento para el botón "Agregar"
        private void button_agregar_Click(object sender, EventArgs e)
        {
        }

        // Evento para el botón "Limpiar"
        private void button_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtbox_codigoproducto.Clear();
            txtbox_nombreproducto.Clear();
            txtbox_precio.Clear();
            txtbox_cantidad.Clear();
        }
    }
}
