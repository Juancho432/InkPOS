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
using System.Security.Cryptography;
using static InkPos.Excepciones;
using System.Text.RegularExpressions;

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

            // Validar campos vacíos (excepto para el cargo que usa CB_cargo)
            try
            {
                if ((string.IsNullOrWhiteSpace(cedulaEmpleado) ||
                    string.IsNullOrWhiteSpace(nuevoValor)) && campoSeleccionado != 2)
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch (Excepciones.CamposVacios)
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.");
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
                    case 0: // Nombre
                        empleadoExistente.Nombre = nuevoValor;
                        break;

                    case 1: // Teléfono
                        if (!Regex.IsMatch(nuevoValor, @"^\d+$"))
                            throw new FormatException("El número de teléfono debe contener solo números.");
                        empleadoExistente.Telefono = nuevoValor;
                        break;

                    case 2: // Cargo
                        empleadoExistente.Es_Admin = CB_cargo.SelectedIndex == 1;
                        break;

                    case 3: // Salario
                        if (!double.TryParse(nuevoValor, out double nuevoSalario))
                            throw new FormatException("El salario debe ser un número válido.");
                        empleadoExistente.Salario = nuevoSalario;
                        break;

                    case 4: // Usuario
                        if (!ActualizarUsuario(empleadoExistente.Id_Empleado, nuevoValor))
                        {
                            MessageBox.Show("No se pudo actualizar el usuario.");
                            return;
                        }
                        MessageBox.Show("Usuario actualizado exitosamente.");
                        Close();
                        return;

                    case 5: // Contraseña
                        if (!ActualizarContrasena(empleadoExistente.Id_Empleado, nuevoValor))
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña.");
                            return;
                        }
                        MessageBox.Show("Contraseña actualizada exitosamente.");
                        Close();
                        return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Actualizar datos generales si no fue usuario/contraseña
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


        private bool ActualizarUsuario(string idEmpleado, string nuevoUsuario)
        {
            using var conn = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={Database.DbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            UPDATE Empleado
            SET Usuario = $usuario
            WHERE ID_Empleado = $id;";
                cmd.Parameters.AddWithValue("$usuario", nuevoUsuario);
                cmd.Parameters.AddWithValue("$id", idEmpleado);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();
            }
        }

        private bool ActualizarContrasena(string idEmpleado, string nuevaContrasena)
        {
            using var conn = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={Database.DbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            UPDATE Empleado
            SET Contrasena = $pass
            WHERE ID_Empleado = $id;";
                cmd.Parameters.AddWithValue("$pass", ToSHA256(nuevaContrasena));
                cmd.Parameters.AddWithValue("$id", idEmpleado);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();
            }
        }

        private string ToSHA256(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input), "El valor para hashear no puede ser nulo o vacío.");

            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
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
            txtbox_cedula.Text=EmpleadoActual.Id_Empleado.ToString();
        }
    }
}
