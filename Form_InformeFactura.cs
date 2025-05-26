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
            txtbox_Señor.Visible = false;
            txtbox_NIT.Visible = false;
            txtbox_Telefono.Visible = false;
            txtbox_Direccion.Visible = false;
            txtbox_Num.Visible = false;
            txtbox_Empleado.Visible = false;
            txtbox_Fecha.Visible = false;
            txtbox_Metodo.Visible = false;
            txtbox_Total_Cantidad.Visible = false;
            txtbox_Valor_Total.Visible = false;

            lbl_Señor.Text = ClienteActual.NombreCliente;
            lbl_Nit.Text = ClienteActual.IdCliente;
            lbl_Telefono.Text = ClienteActual.Telefono;
            lbl_Direccion.Text = ClienteActual.Direccion;
            lbl_Num.Text = FacturaActual.IdFactura.ToString();
            lbl_Empleado.Text = EmpleadoActual.Nombre;
            lbl_Fecha.Text = FacturaActual.Fecha + " " + FacturaActual.Hora;
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

            // ✅ Solo los administradores pueden editar
            if (EmpleadoActual.Es_Admin)
            {
                lbl_Señor.Click += (s, e) => HacerLabelEditable(lbl_Señor, txtbox_Señor);
                lbl_Nit.Click += (s, e) => HacerLabelEditable(lbl_Nit, txtbox_NIT);
                lbl_Telefono.Click += (s, e) => HacerLabelEditable(lbl_Telefono, txtbox_Telefono);
                lbl_Direccion.Click += (s, e) => HacerLabelEditable(lbl_Direccion, txtbox_Direccion);
                lbl_Num.Click += (s, e) => HacerLabelEditable(lbl_Num, txtbox_Num);
                lbl_Empleado.Click += (s, e) => HacerLabelEditable(lbl_Empleado, txtbox_Empleado);
                lbl_Fecha.Click += (s, e) => HacerLabelEditable(lbl_Fecha, txtbox_Fecha);
                lbl_Metodo.Click += (s, e) => HacerLabelEditable(lbl_Metodo, txtbox_Metodo);
                lbl_Total_Cantidad.Click += (s, e) => HacerLabelEditable(lbl_Total_Cantidad, txtbox_Total_Cantidad);
                lbl_Valor_Total.Click += (s, e) => HacerLabelEditable(lbl_Valor_Total, txtbox_Valor_Total);
            }

        }

        private void HacerLabelEditable(Label label, TextBox textBox)
        {
            // Solo cambia la posición, NO el tamaño
            var formLocation = label.Parent.PointToScreen(label.Location);
            var controlLocation = this.PointToClient(formLocation);
            textBox.Location = controlLocation;

            // NO sobreescribas el tamaño
            // textBox.Size = label.Size;

            textBox.Text = label.Text;
            textBox.Visible = true;
            textBox.BringToFront();
            textBox.Focus();
            textBox.SelectAll();

            textBox.Leave += (s, e) =>
            {
                label.Text = textBox.Text;
                textBox.Visible = false;
            };

            textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    label.Text = textBox.Text;
                    textBox.Visible = false;
                    e.SuppressKeyPress = true;
                }
            };
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
