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
            Close();
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            string cedulaEmpleado = txtbox_cedula.Text.Trim();
            int campoSeleccionado = CB_valor_a_modificar.SelectedIndex;
            string nuevoValor = txtbox_nuevo_valor.Text.Trim();

            // Validar campos vacíos
            try
            {
                if ((string.IsNullOrWhiteSpace(cedulaEmpleado) ||
                    string.IsNullOrWhiteSpace(nuevoValor)) && CB_valor_a_modificar.SelectedIndex != 2)
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch (Excepciones.CamposVacios)
            {
                return;
            }


            // Buscar empleado
            Empleado empleadoExistente;
            try
            {
                empleadoExistente = Database.ReadEmployedByID(cedulaEmpleado);
            }
            catch
            {
                MessageBox.Show("Empleado no encontrado.");
                return;
            }


            // Actualizar campo seleccionado
            try
            {
                switch (campoSeleccionado)
                {
                    // Nombre
                    case 0:
                        empleadoExistente.Nombre = nuevoValor;
                        break;

                    // Telefono
                    case 1:
                        empleadoExistente.Telefono = nuevoValor;
                        break;

                    // Cargo
                    case 2:
                        empleadoExistente.Es_Admin = CB_cargo.SelectedIndex == 1;
                        break;

                    // Salario
                    case 3:
                        if (!double.TryParse(nuevoValor, out double nuevoSalario))
                        {
                            throw new FormatException("El salario debe ser un número válido.");
                        }
                        else
                        {
                            empleadoExistente.Salario = nuevoSalario;
                        }
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Actualizar en base de datos
            bool exito = Database.UpdateEmployedData(empleadoExistente);

            if (exito)
            {
                MessageBox.Show("Empleado modificado exitosamente.");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el empleado.");
            }
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_cedula.Clear();
            txtbox_nuevo_valor.Clear();
            CB_valor_a_modificar.SelectedIndex = -1;
            CB_cargo.SelectedIndex = -1;
        }

        private void CB_valor_a_modificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_valor_a_modificar.SelectedIndex == 2)
            {
                lbl_cargo.Visible = true;
                CB_cargo.Visible = true;

                lbl_ingresevalor.Visible = false;
                txtbox_nuevo_valor.Visible = false;
            }
            else
            {
                lbl_cargo.Visible = false;
                CB_cargo.Visible = false;

                lbl_ingresevalor.Visible = true;
                txtbox_nuevo_valor.Visible = true;
            }
        }

        private void Form_Modificar_Empleado_Load(object sender, EventArgs e)
        {
            lbl_cargo.Visible = false;
            CB_cargo.Visible = false;
        }
    }
}
