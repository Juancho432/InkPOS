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
            Form_Gestion_Productos maestro_productos = new(EmpleadoActual, Database);
            maestro_productos.Show();
            Hide();
            maestro_productos.FormClosed += (s, args) => this.Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_GEmpleados_Click(object sender, EventArgs e)
        {
            Form_Gestion_Empleados gestion_empleados = new(EmpleadoActual, Database);
            gestion_empleados.Show();
            Hide();
            gestion_empleados.FormClosed += (s, args) => this.Show();
        }

        private void panel_home_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Home_Admin_Load(object sender, EventArgs e)
        {
            lbl_nombreUsuario.Text = EmpleadoActual.Nombre;
        }

        private void button_facturas_Click(object sender, EventArgs e)
        {
            Form_Gestion_Facturas gestion_facturas = new(EmpleadoActual, Database);
            gestion_facturas.Show();
            Hide();
            gestion_facturas.FormClosed += (s, args) => this.Show();
        }

        private void button_reporte_ventas_Click(object sender, EventArgs e)
        {
            Form_Reporte_Venta reporte_Venta = new(EmpleadoActual, Database);
            reporte_Venta.Show();
            Hide();
            reporte_Venta.FormClosed += (s, args) => this.Show();
        }


    }
}
