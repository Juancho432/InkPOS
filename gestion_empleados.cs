using System;
using System.Windows.Forms;

namespace InkPos
{
    public partial class gestion_empleados : Form
    {
        private EmpleadoManager empleadoManager;

        public gestion_empleados()
        {
            InitializeComponent();
            empleadoManager = new EmpleadoManager();
        }

        // Botón: Nuevo Empleado (para limpiar los campos)
        private void button_agregar_empleado_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón: Confirmar (guardar cambios o registrar)
        private void button_confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_cedula.Text) ||
                string.IsNullOrWhiteSpace(txtbox_nombre.Text) ||
                string.IsNullOrWhiteSpace(txtbox_telefono.Text) ||
                string.IsNullOrWhiteSpace(txtbox_cargo.Text) ||
                string.IsNullOrWhiteSpace(txtbox_salario.Text))
            {
                MessageBox.Show("Advertencia: Hay campos vacíos.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtbox_salario.Text, out salario) || salario <= 0)
            {
                MessageBox.Show("Advertencia: Salario inválido.");
                return;
            }

            Empleado empleado = new Empleado
            {
                IdEmpleado = txtbox_cedula.Text,
                Nombre = txtbox_nombre.Text,
                Telefono = txtbox_telefono.Text,
                Cargo = txtbox_cargo.Text,
                Salario = salario,
                // Los campos de Usuario y Contraseña se mantienen vacíos aquí,
                // asumiendo que solo modificas los datos principales.
            };

            string resultado = empleadoManager.ModificarEmpleado(empleado);
            MessageBox.Show(resultado);
        }

        // Botón: Limpiar (limpia todos los campos)
        private void button_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón: Salir (cierra el formulario)
        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TextChanged para campo de cédula (para buscar empleado)
        private void txtbox_cedula_TextChanged(object sender, EventArgs e)
        {
            Empleado empleado = empleadoManager.BuscarEmpleado(txtbox_cedula.Text);
            if (empleado != null)
            {
                txtbox_nombre.Text = empleado.Nombre;
                txtbox_telefono.Text = empleado.Telefono;
                txtbox_cargo.Text = empleado.Cargo;
                txtbox_salario.Text = empleado.Salario.ToString();
            }
            else
            {
                // Si quieres, puedes limpiar los campos o mostrar mensaje:
                // LimpiarCampos();
                // MessageBox.Show("Empleado no encontrado.");
            }
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

        // Estos eventos pueden quedar vacíos si no tienes lógica aún:
        private void gestion_empleados_Load(object sender, EventArgs e) { }
        private void lbl_nuevovalor_Click(object sender, EventArgs e) { }
        private void txtbox_nombre_TextChanged(object sender, EventArgs e) { }
        private void txtbox_telefono_TextChanged(object sender, EventArgs e) { }
        private void txtbox_cargo_TextChanged(object sender, EventArgs e) { }
        private void txtbox_salario_TextChanged(object sender, EventArgs e) { }
    }
}
