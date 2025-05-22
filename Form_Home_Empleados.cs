namespace InkPos
{
    public partial class Form_Home_Empleados : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Home_Empleados(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_venta_Click(object sender, EventArgs e)
        {
            Form_Venta FormVenta = new(EmpleadoActual, Database);
            FormVenta.Show();
            Hide();
            FormVenta.FormClosed += (s, args) => Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_facturas_Click(object sender, EventArgs e)
        {
            Form_Busqueda_factura FromFactura = new(EmpleadoActual, Database);
            FromFactura.Show();
            Hide();
            FromFactura.FormClosed += (s, args) => Show();
        }

        private void Form_Home_Empleados_Load(object sender, EventArgs e)
        {
            lbl_nombreUsuario.Text = EmpleadoActual.Nombre;
        }
    }
}
