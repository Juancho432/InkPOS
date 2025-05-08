using System;
using System.Windows.Forms;

namespace InkPos
{
    public partial class gestion_empleados : Form
    {

        public gestion_empleados()
        {
            InitializeComponent();
        }

        // Botón: Nuevo Empleado (para limpiar los campos)
        private void button_agregar_empleado_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón: Confirmar (guardar cambios o registrar)
        private void button_confirmar_Click(object sender, EventArgs e)
        {
            
        }

        // Botón: Limpiar (limpia todos los campos)
        private void button_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón: Salir (cierra el formulario)
        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtbox_cedula.Clear();
            txtbox_nombre.Clear();
            txtbox_telefono.Clear();
            txtbox_cargo.Clear();
            txtbox_salario.Clear();
        }
    }
}
