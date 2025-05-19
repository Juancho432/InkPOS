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
    public partial class Form_Agregar_Empleado : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Agregar_Empleado(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Boton_Agregar_Empleado_Click(object sender, EventArgs e)
        {
            string nombre_empleado = txtbox_nombre_empleado.Text.Trim();
            string cedula_empleado = txtbox_cedula.Text.Trim();
            string telefono_empleado = txtbox_telefono.Text.Trim();
            int cargo_empleado = CB_cargo.SelectedIndex;
            string salario_empleado = txtbox_salario.Text.Trim();
            string usuario_empleado = txtbox_usuario.Text.Trim();
            string contrasena_empleado = txtbox_contraseña.Text.Trim();

            // Validar campos vacíos
            try
            {
                if (string.IsNullOrEmpty(nombre_empleado) ||
                    string.IsNullOrEmpty(cedula_empleado) ||
                    string.IsNullOrEmpty(telefono_empleado) ||
                    string.IsNullOrEmpty(salario_empleado) ||
                    string.IsNullOrEmpty(usuario_empleado) ||
                    string.IsNullOrEmpty(contrasena_empleado))
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch
            {
                return;
            }
            // Convertir el cargo a minúsculas para una comparación segura
            bool esAdmin = cargo_empleado == 1;

            if (!double.TryParse(salario_empleado, out double salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            // Crear el objeto empleado
            Empleado nuevoEmpleado = new(cedula_empleado, nombre_empleado, telefono_empleado, esAdmin, salario);

            //// Guardar en la base de datos
            try
            {
                Database.CreateEmployed(nuevoEmpleado, usuario_empleado, contrasena_empleado);
            }
            catch
            {
                return;
            }
            MessageBox.Show("Empleado registrado correctamente.");
            Close(); 

        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            txtbox_nombre_empleado.Clear();
            txtbox_cedula.Clear();
            txtbox_telefono.Clear();
            CB_cargo.SelectedIndex = -1;
            txtbox_salario.Clear();
            txtbox_usuario.Clear();
            txtbox_contraseña.Clear();
        }
    }
}
