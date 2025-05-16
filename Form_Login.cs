namespace InkPos
{
    public partial class Form_Login : Form
    {
        private DataBaseHandler Database;

        public Form_Login(DataBaseHandler database)
        {
            Database = database;
            InitializeComponent();
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtbox_contraseña.PasswordChar = '●'; 
            PB_ver.Visible = true;
            PB_ocultar.Visible = false;

        }
        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Obtener los datos
            string usuario = txtbox_ID_usuario.Text;
            string contraseña = txtbox_contraseña.Text;

            // Verificar que ningun campo este vacio
            try
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch
            {
                txtbox_ID_usuario.Text = string.Empty;
                txtbox_contraseña.Text = string.Empty;
                txtbox_ID_usuario.Focus();
                return;
            }

            // Loguear al empleado
            Empleado EmpleadoActual;
            try
            {
                EmpleadoActual = Database.LoginEmployed(usuario, contraseña);
            }
            catch
            {
                txtbox_ID_usuario.Text = string.Empty;
                txtbox_contraseña.Text = string.Empty;
                txtbox_ID_usuario.Focus();
                return;
            }

            // Mostrar el Home dependiendo si es admin o empleado
            if (EmpleadoActual.Es_Admin)
            {
                Form_Home_Admin FormAdmin = new(EmpleadoActual, Database);
                FormAdmin.Show();
                Hide();
                FormAdmin.FormClosed += (s, args) => Show();
            }
            else
            {
                Form_Home_Empleados FormEmpleado = new(EmpleadoActual, Database);
                FormEmpleado.Show();
                Hide();
                FormEmpleado.FormClosed += (s, args) => Show();
            }
        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            txtbox_ID_usuario.Text = string.Empty;
            txtbox_contraseña.Text = string.Empty;
            txtbox_ID_usuario.Focus();
        }

        private void Boton_Salir_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PB_ver_Click(object sender, EventArgs e)
        {
            txtbox_contraseña.UseSystemPasswordChar = false;
            txtbox_contraseña.PasswordChar = '\0'; // Mostrar contraseña
            PB_ver.Visible = false;
            PB_ocultar.Visible = true;
        }

        private void PB_ocultar_Click(object sender, EventArgs e)
        {
            txtbox_contraseña.UseSystemPasswordChar = false;
            txtbox_contraseña.PasswordChar = '●'; // Ocultar contraseña
            PB_ver.Visible = true;
            PB_ocultar.Visible = false;
        }
    }
}

