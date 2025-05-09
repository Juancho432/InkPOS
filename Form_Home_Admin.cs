namespace InkPos
{
    public partial class Form_Home_Admin : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Home_Admin(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();

        }

        private void Boton_Maestro_Productos_CLick(object sender, EventArgs e)
        {
            Form_Maestro_Productos maestro_productos = new(EmpleadoActual, Database);
            maestro_productos.Show();
            Hide();
            maestro_productos.FormClosed += (s, args) => this.Show();
        }
    }
}
