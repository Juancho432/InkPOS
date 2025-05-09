using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_modificar_producto : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        public Form_modificar_producto(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        // Evento para el botón "Confirmar"
        private void button_confirmar_Click(object sender, EventArgs e)
        {
            
        }

        // Evento para el botón "Cancelar"
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
