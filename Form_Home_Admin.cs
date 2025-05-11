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

        private void button_maestro_productos_Click(object sender, EventArgs e)
        {
            Form_Maestro_Productos maestro_productos = new(EmpleadoActual, Database);
            maestro_productos.Show();
            Hide();
            maestro_productos.FormClosed += (s, args) => this.Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
