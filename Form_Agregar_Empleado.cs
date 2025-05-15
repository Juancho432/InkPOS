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

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_empleado_Click(object sender, EventArgs e)
        {
            string nombre_empleado = txtbox_nombre_empleado.Text.Trim();
            string cedula_empleado = txtbox_cedula.Text.Trim();
            string telefono_empleado = txtbox_telefono.Text.Trim();
            string cargo_empleado = CB_cargo.SelectedItem?.ToString();
            string salario_empleado = txtbox_salario.Text.Trim();

            // Validar campos vacíos
            try
            {
                if (string.IsNullOrEmpty(nombre_empleado) ||
                    string.IsNullOrEmpty(cedula_empleado) ||
                    string.IsNullOrEmpty(telefono_empleado) ||
                    string.IsNullOrEmpty(cargo_empleado) ||
                    string.IsNullOrEmpty(salario_empleado))
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch
            {
                return;
            }

            // Convertir el cargo a minúsculas para una comparación segura
            bool esAdmin = cargo_empleado.ToLower() == "administrador";

            if (!double.TryParse(salario_empleado, out double salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            // Crear el objeto empleado
            Empleado nuevoEmpleado = new(cedula_empleado, nombre_empleado, telefono_empleado, esAdmin, salario);

            //// Guardar en la base de datos
            //try
            //{
            //    Database.CreateEmpleado(nuevoEmpleado); // Asegúrate de tener este método en tu clase DataBaseHandler
            //}
            //catch
            //{
            //    return;
            //}

            //MessageBox.Show("Empleado registrado correctamente.");


            this.Close(); 

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_nombre_empleado.Clear();
            txtbox_cedula.Clear();
            txtbox_telefono.Clear();
            CB_cargo.SelectedIndex = -1;
            txtbox_salario.Clear();
        }
    }
}
