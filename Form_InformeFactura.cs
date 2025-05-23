namespace InkPos
{
    public partial class Form_InformeFactura : Form
    {
        private readonly Factura FacturaActual;
        private readonly Empleado EmpleadoActual;
        private readonly Cliente ClienteActual;

        public Form_InformeFactura(Factura factura, Empleado empleado, Cliente cliente)
        {
            FacturaActual = factura;
            EmpleadoActual = empleado;
            ClienteActual = cliente;
            InitializeComponent();
        }

        private void InformeFactura_Load(object sender, EventArgs e)
        {
            lbl_Señor.Text = ClienteActual.NombreCliente;
            lbl_Nit.Text = ClienteActual.IdCliente;
            lbl_Telefono.Text = ClienteActual.Telefono;
            lbl_Direccion.Text = ClienteActual.Direccion;
            lbl_Num.Text = FacturaActual.IdFactura.ToString();
            lbl_Empleado.Text = EmpleadoActual.Nombre;
            lbl_Fecha.Text = FacturaActual.Fecha +" "+ FacturaActual.Hora;
            lbl_Metodo.Text = FacturaActual.IdTransaccion == null ? "Efectivo" : 
                                                                    "Transferencia " + FacturaActual.IdTransaccion;

            int cantidad = 0;
            foreach (DetalleVenta item in FacturaActual.Detalles)
            {
                detalleVentaBindingSource.Add(item);
                cantidad += item.Cantidad;
            }

            lbl_Total_Cantidad.Text = cantidad.ToString();
            lbl_Valor_Total.Text = FacturaActual.Total.ToString();
        }

        private void Boton_Imprimir_Click(object sender, EventArgs e)
        {
            PrintService.GenPDF(FacturaActual, ClienteActual, EmpleadoActual);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
