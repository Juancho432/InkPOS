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
using static InkPos.Excepciones;

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
            string cedulaEmpleado = txtbox_cedula.Text.Trim();
            string campoSeleccionado = CB_valor_a_modificar.SelectedItem?.ToString();
            string nuevoValor = txtbox_nuevo_valor.Text.Trim();
            string nuevoCargo = CB_cargo.SelectedItem?.ToString();


            // Validar campos vacíos
            try
            {
                if (string.IsNullOrWhiteSpace(cedulaEmpleado) ||
                    string.IsNullOrWhiteSpace(campoSeleccionado) ||
                    string.IsNullOrWhiteSpace(nuevoValor) ||
                    string.IsNullOrWhiteSpace(nuevoCargo))
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch (Excepciones.CamposVacios)
            {
                return;
            }


            // Buscar empleado
            //Empleado empleadoExistente;
            //try
            //{
            //    empleadoExistente = Database.ReadEmployeeByID(cedulaEmpleado); 
            //}
            //catch
            //{
            //    MessageBox.Show("Empleado no encontrado.");
            //    return;
            //}


            // Actualizar campo seleccionado
            //try
            //{
            //    switch (campoSeleccionado)
            //    {
            //        case "Nombre":
            //            empleadoExistente = new Empleado(
            //                empleadoExistente.Id_Empleado,
            //            nuevoValor,
            //                empleadoExistente.Telefono,
            //                nuevoCargo.ToLower() == "administrador",
            //                empleadoExistente.Salario);
            //            break;

            //        case "Télefono":
            //            empleadoExistente = new Empleado(
            //                empleadoExistente.Id_Empleado,
            //                empleadoExistente.Nombre,
            //                nuevoValor,
            //                nuevoCargo.ToLower() == "administrador",
            //                empleadoExistente.Salario);
            //            break;

            //        case "Salario":
            //            if (!double.TryParse(nuevoValor, out double nuevoSalario))
            //                throw new FormatException("El salario debe ser un número válido.");

            //            empleadoExistente = new Empleado(
            //                empleadoExistente.Id_Empleado,
            //            empleadoExistente.Nombre,
            //                empleadoExistente.Telefono,
            //                nuevoCargo.ToLower() == "administrador",
            //                nuevoSalario);
            //            break;

            //        default:
            //            MessageBox.Show("El campo seleccionado no es válido.");
            //            return;
            //    }
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;

            //}

            // Actualizar en base de datos
            //bool exito = Database.ActualizarEmpleado(empleadoExistente); // Asegúrate de tener este método

            //if (exito)
            //{
            //    MessageBox.Show("Empleado modificado exitosamente.");
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo modificar el empleado.");
            //}




        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_cedula.Clear();
            txtbox_nuevo_valor.Clear();
            CB_valor_a_modificar.SelectedIndex = -1;
            CB_cargo.SelectedIndex = -1;
        }
    }
}
