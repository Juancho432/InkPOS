
namespace InkPos
{
    public partial class Form_Busqueda_factura : Form
    {
        private readonly Empleado EmpleadoActual;
        private readonly DataBaseHandler Database;

        public Form_Busqueda_factura(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Boton_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Factura busqueda = Database.ReadInvoiceByID(txtbox_ingresar_N_factura.Text);
                Cliente cliente = Database.ReadClientByID(busqueda.IdCliente);
                Empleado empleado = Database.ReadEmployedByID(busqueda.IdEmpleado);
                PrintService.GenPDF(busqueda, cliente, empleado);
            }
            catch
            {
                return;
            }
        }

        private void Link_Label_Ver_Click(object sender, EventArgs e)
        {
            try
            {
                Factura busqueda = Database.ReadInvoiceByID(txtbox_ingresar_N_factura.Text);
                Cliente cliente = Database.ReadClientByID(busqueda.IdCliente);
                Empleado empleado = Database.ReadEmployedByID(busqueda.IdEmpleado);
                Form_InformeFactura informe = new(busqueda, empleado, cliente);
                informe.Show();
                Hide();
                informe.FormClosed += (s, args) => Show();
            }
            catch
            {
                return;
            }
        }
    }
}
