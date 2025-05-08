namespace InkPos
{
    public partial class Form_Login : Form
    {
        private readonly DataBaseHandler Database;
        
        public Form_Login(DataBaseHandler database)
        {
            Database = database;
            InitializeComponent();
        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            txtbox_ID.Clear();
            txtbox_contraseña.Clear();
            txtbox_ID.Focus();
        }

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string usuario = txtbox_ID.Text.Trim();
            string contrasena = txtbox_contraseña.Text.Trim();

            // Validar campos vacíos
            try
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
                {
                    // Lanzar la ventana de campos vacios
                    throw new Excepciones.CamposVacios();
                }
            }
            catch
            {
                return;
            }

            Empleado empleadoActual;

            // Intentar el logueo
            try
            {
                // Consultar los datos en la BBDD
                empleadoActual = Database.LoginEmpleado(usuario, contrasena);
            }
            // Si el usuario no existe o algun dato es incorrecto
            catch
            {
                return;
            }

            if (empleadoActual != null)
            {
                // Login exitoso: redirigir según el rol
                MessageBox.Show($"Bienvenido {empleadoActual.Nombre} " +
                    // Mostrar el cargo que tiene el empleado
                    $"({(empleadoActual.Es_Admin == true ? "Admin" : "Empleado")})",
                    "Ingreso exitoso");

                if (empleadoActual.Es_Admin == true)
                {
                    // Formulario para administrador
                    Form_Home_Admin homeAdmin = new(Database, empleadoActual);  
                    homeAdmin.Show();
                }
                else
                {
                    // Formulario para empleados
                    Form_Home_Empleado homeEmpleado = new();  
                    homeEmpleado.Show();
                }

                // Ocultar el formulario de login
                Hide(); 
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
