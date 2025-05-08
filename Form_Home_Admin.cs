namespace InkPos
{
    public partial class Form_Home_Admin : Form
    {
        private readonly DataBaseHandler Database;
        private readonly Empleado Admin;
        public Form_Home_Admin(DataBaseHandler database, Empleado admin)
        {
            Database = database;
            Admin = admin;
            InitializeComponent();
        }

        private void Boton_Venta_Click(object sender, EventArgs e)
        {
            busqueda_productos busqueda_Productos = new busqueda_productos();
            busqueda_Productos.Show();
            this.Hide(); // Oculta Form1 en lugar de cerrarlo
            busqueda_Productos.FormClosed += (s, args) => this.Show();
        }

        private void button_maestro_productos_Click(object sender, EventArgs e)
        {
            seleccion_maestro_productos seleccion_Maestro_Productos = new seleccion_maestro_productos();
            seleccion_Maestro_Productos.Show();
            this.Hide();
            seleccion_Maestro_Productos.FormClosed += (s, args) => this.Show();
        }

        private void button_gestion_empleados_Click(object sender, EventArgs e)
        {
            gestion_empleados gestion_Empleados = new gestion_empleados();
            gestion_Empleados.Show();
            this.Hide();
            gestion_Empleados.FormClosed += (s, args) => this.Show();
        }

        private void button_facturas_Click(object sender, EventArgs e)
        {
            busqueda_factura busqueda_Factura = new busqueda_factura();
            busqueda_Factura.Show();
            this.Hide();
            busqueda_Factura.FormClosed += (s, args) => this.Show();
        }

        private void Form_Home_Admin_Load(object sender, EventArgs e)
        {
            lbl_nombre_empleado.Text = Admin.Nombre;
        }
    }
}
