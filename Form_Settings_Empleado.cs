using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InkPos.Excepciones;

namespace InkPos
{
    public partial class Form_Settings_Empleado : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Settings_Empleado(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        //método que genera hash en hexadecimal
        private string ToSHA256(string input)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2")); // hex string
            }
            return sb.ToString();
        }

        public string ObtenerHashContrasena(string idEmpleado, string dbPath)
        {
            using var conn = new SqliteConnection($"Data Source={dbPath}");
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                            SELECT Contrasena
                            FROM Empleado
                            WHERE ID_Empleado = $id;";
            cmd.Parameters.AddWithValue("$id", idEmpleado);

            var result = cmd.ExecuteScalar();
            return result?.ToString() ?? throw new EmpleadoInexistente();
        }

        private void Form_Settings_Empleado_Load(object sender, EventArgs e)
        {
            txtbox_telefono.Text = EmpleadoActual.Telefono;
            InicializarControles();
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasenaActualIngresada = txtbox_actual_password.Text.Trim();
                string nuevaContrasena = txtbox_new_password.Text.Trim();
                string telefonoNuevo = txtbox_telefono.Text.Trim();

                if (string.IsNullOrWhiteSpace(contrasenaActualIngresada))
                {
                    MessageBox.Show("Debes ingresar la contraseña actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashGuardado = ObtenerHashContrasena(EmpleadoActual.Id_Empleado, Database.DbPath);
                string hashIngresado = ToSHA256(contrasenaActualIngresada); 


                if (!hashGuardado.Equals(hashIngresado, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si todo está bien, actualizar el teléfono (y tal vez la contraseña)
                EmpleadoActual.Telefono = telefonoNuevo;
                bool actualizado = Database.UpdateEmployedData(EmpleadoActual);

                if (actualizado)
                {
                    if (!string.IsNullOrWhiteSpace(nuevaContrasena))
                    {
                        string nuevoHash = ToSHA256(nuevaContrasena);
                        bool passActualizada = ActualizarContrasena(EmpleadoActual.Id_Empleado, nuevoHash);

                        if (passActualizada)
                            MessageBox.Show("Datos actualizados correctamente.\nLa contraseña fue cambiada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Teléfono actualizado.\nNo se pudo cambiar la contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Teléfono actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ActualizarContrasena(string idEmpleado, string hashContrasenaNueva)
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
                cmd.Parameters.AddWithValue("$pass", hashContrasenaNueva);
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

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InicializarControles()
        {
            txtbox_new_password.PasswordChar = '●'; // Ocultar al inicio
            PB_ver.Visible = true;
            PB_ocultar.Visible = false;
        }

        private void PB_ver_Click(object sender, EventArgs e)
        {
            txtbox_new_password.UseSystemPasswordChar = false;
            txtbox_new_password.PasswordChar = '\0'; // Mostrar contraseña
            PB_ver.Visible = false;
            PB_ocultar.Visible = true;
        }

        private void PB_ocultar_Click(object sender, EventArgs e)
        {
            txtbox_new_password.UseSystemPasswordChar = false;
            txtbox_new_password.PasswordChar = '●'; // Ocultar contraseña
            PB_ver.Visible = true;
            PB_ocultar.Visible = false;
        }


    }
}
