using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;
using static InkPos.Excepciones;

namespace InkPos
{
    public partial class Form_Settings_Empleado : Form
    {
        private readonly Empleado EmpleadoActual;
        private readonly DataBaseHandler Database;

        public Form_Settings_Empleado(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        //método que genera hash en hexadecimal
        private static string ToSHA256(string input)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2")); // hex string
            }
            return sb.ToString();
        }

        public static string ObtenerHashContrasena(string idEmpleado, string dbPath)
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
            txtbox_new_password.PasswordChar = '●'; // Ocultar al inicio
            PB_ver.Visible = true;
            PB_ocultar.Visible = false;
        }

        private void Button_saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasenaActualIngresada = txtbox_actual_password.Text.Trim();
                string nuevaContrasena = txtbox_new_password.Text.Trim();
                string telefonoNuevo = txtbox_telefono.Text.Trim();

                if (string.IsNullOrEmpty(telefonoNuevo) && string.IsNullOrEmpty(nuevaContrasena))
                {
                    Close();
                    return;
                }

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

                // Actualizar telefono
                if (!string.IsNullOrEmpty(telefonoNuevo))
                {
                    EmpleadoActual.Telefono = telefonoNuevo;
                    Database.UpdateEmployedData(EmpleadoActual);
                }
                
                if (txtbox_actual_password.Text == txtbox_new_password.Text)
                {
                    MessageBox.Show("La contraseña nueva no puede ser igual a la actual", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar contraseña
                if (!string.IsNullOrEmpty(nuevaContrasena))
                {
                    Database.UpdateEmployedLogin(EmpleadoActual, nuevaContrasena);
                }

                MessageBox.Show("Datos actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
