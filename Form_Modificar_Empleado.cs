using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Modificar_Empleado : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Modificar_Empleado(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            string cedula_empleado = txtbox_cedula.Text.Trim();
            string nombre_empleado = txtbox_nombre_empleado.Text.Trim();
            string telefono_empleado = txtbox_telefono.Text.Trim();
            string cargo_empleado = txtbox_cargo.Text.Trim();
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
            bool esAdmin = cargo_empleado.Trim().ToLower() == "administrador";

            if (!double.TryParse(salario_empleado, out double salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            // Crear objeto actualizado
            Empleado empleadoActualizado = new(cedula_empleado, nombre_empleado, telefono_empleado, esAdmin, salario);


            // Actualizar en base de datos
            //try
            //{
            //    bool exito = Database.ActualizarEmpleado(empleadoActualizado);

            //    if (exito)
            //    {
            //        MessageBox.Show("Empleado actualizado correctamente.");
            //        this.Close(); // Cierra y regresa al formulario anterior
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo actualizar el empleado. Verifica que la cédula sea correcta.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            //}


        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_nombre_empleado.Clear();
            txtbox_cedula.Clear();
            txtbox_telefono.Clear();
            txtbox_cargo.Clear();
            txtbox_salario.Clear();
        }

        private void panel_gestion_empleados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
