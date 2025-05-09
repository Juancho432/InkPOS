namespace InkPos
{
    public partial class Form_InformeFactura : Form
    {

        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_InformeFactura(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }
        public Form_InformeFactura(List<DetalleVenta> detallesVenta)
        {
            InitializeComponent();
            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.DataSource = detallesVenta;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void InformeFactura_Load(object sender, EventArgs e)
        {
            // BBDD aqui
        }
    }
}
