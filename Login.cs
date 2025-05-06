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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.button_limpiar.Click += new System.EventHandler(this.button2_Click);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_ID.Clear();
            txtbox_contraseña.Clear();
            txtbox_ID.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txtbox_ID.Text.Trim();
            string contrasena = txtbox_contraseña.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Campos vacíos. Por favor ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de la clase Empleado
            Empleado empleado = new Empleado();

            // Verificar credenciales
            LoginService loginService = new LoginService();
            Empleado empleadoLogueado = loginService.IniciarSesion(usuario, contrasena);

            if (empleadoLogueado != null)
            {
                // Login exitoso: redirigir según el rol
                MessageBox.Show($"Bienvenido {empleadoLogueado.Nombre} ({empleadoLogueado.Cargo})", "Ingreso exitoso");

                if (empleadoLogueado.Cargo.ToLower() == "administrador")
                {
                    menu_opciones_admin ventanaAdmin = new menu_opciones_admin();  // formulario para administrador
                    ventanaAdmin.Show();
                }
                else
                {
                    menu_opciones_empleado ventanaEmpleado = new menu_opciones_empleado();  // formulario para empleados
                    ventanaEmpleado.Show();
                }

                this.Hide(); // Oculta el formulario de login
            }
            else
            {
                // Credenciales inválidas
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class LoginService
        {
            public Empleado IniciarSesion(string usuario, string contrasena)
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                {
                    throw new Exception("Campos vacíos. Por favor ingrese usuario y contraseña.");
                }

                Empleado empleado = new Empleado();
                var empleadoLogueado = empleado.VerificarCredenciales(usuario, contrasena);

                if (empleadoLogueado == null)
                    throw new Exception("Usuario o contraseña incorrectos.");

                return empleadoLogueado;
            }
        }
    }
}
