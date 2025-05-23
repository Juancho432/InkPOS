namespace InkPos
{
    public partial class Form_Ventana_Pago : Form
    {

        private readonly DataBaseHandler Database;
        private readonly decimal ValorTotal;
        private Factura FacturaActual;
        private Empleado EmpleadoActual;
        private Cliente ClienteActual;

        public Form_Ventana_Pago(DataBaseHandler database, Factura factura, Empleado empleado, Cliente cliente)
        {
            FacturaActual = factura;
            Database = database;
            ValorTotal = factura.Total;
            EmpleadoActual = empleado;
            ClienteActual = cliente;
            InitializeComponent();
        }

        private decimal CalcularCambio()
        {
            // Intentar convertir los valores a números decimales
            if (!string.IsNullOrEmpty(txtbox_valor_recibido.Text) &&
                decimal.TryParse(txtbox_valor_recibido.Text, out decimal valorRecibido) &&
                decimal.TryParse(txtbox_valor.Text, out decimal valorCompra))
            {
                // Calcular el cambio
                decimal cambio = valorRecibido - valorCompra;

                // Verificar si el dinero recibido es suficiente
                if (cambio < 0)
                {
                    throw new Excepciones.DineroInsuficiente();
                }

                return cambio;
            }
            else
            {
                throw new Excepciones.ValorInvalido();
            }
        }

        private void CB_transaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_transaccion.SelectedItem != null)
            {
                int seleccion = CB_transaccion.SelectedIndex;

                // Efectivo
                if (seleccion == 0)
                {
                    // Mostrar controles relacionados con el pago en efectivo
                    lbl_valor_recibido.Visible = true;
                    txtbox_valor_recibido.Visible = true;
                    lbl_cambio.Visible = true;
                    txtbox_cambio.Visible = true;

                    lbl_codigo_transferencia.Visible = false;
                    txtbox_codigo_transferencia.Visible = false;
                }
                // Transferencia
                else if (seleccion == 1)
                {
                    lbl_codigo_transferencia.Visible = true;
                    txtbox_codigo_transferencia.Visible = true;

                    lbl_valor_recibido.Visible = false;
                    txtbox_valor_recibido.Visible = false;
                    lbl_cambio.Visible = false;
                    txtbox_cambio.Visible = false;
                }
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            switch (CB_transaccion.SelectedIndex)
            {
                // Efectivo
                case 0:
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(txtbox_valor_recibido.Text))
                            {
                                throw new Excepciones.CamposVacios();
                            }

                            if (!decimal.TryParse(txtbox_valor_recibido.Text, out decimal valor))
                            {
                                throw new Excepciones.ValorInvalido();
                            }

                            if (valor < ValorTotal)
                            {
                                throw new Excepciones.DineroInsuficiente();
                            }
                        }
                        catch
                        {
                            return;
                        }
                        FacturaActual.IdTransaccion = null;
                        break;
                    }
                // Transferencia
                case 1: 
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(txtbox_codigo_transferencia.Text))
                            {
                                throw new Excepciones.CamposVacios();
                            }
                        }
                        catch
                        {
                            return;
                        }

                        FacturaActual.IdTransaccion = txtbox_codigo_transferencia.Text;
                        break;
                    }
            }
            FacturaActual.IdFactura = Database.CreateInvoice(FacturaActual);
            MessageBox.Show("Factura creada con exito", "Venta Finalizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrintService.GenPDF(FacturaActual, ClienteActual, EmpleadoActual);
            foreach (DetalleVenta item in FacturaActual.Detalles)
            {
                item.Producto.Stock -= item.Cantidad;
                Database.UpdateProduct(item.Producto);
            }
            Close();
        }

        private void Form_Ventana_Pago_Load(object sender, EventArgs e)
        {
            txtbox_valor.Text = ValorTotal.ToString();
            // Ocultar los controles relacionados con el pago por Transacción
            lbl_codigo_transferencia.Visible = false;
            txtbox_codigo_transferencia.Visible = false;
        }

        private void Txtbox_valor_recibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    txtbox_cambio.Text = CalcularCambio().ToString();
                }
                catch
                {
                    return;
                }
            }
        }
    }
}