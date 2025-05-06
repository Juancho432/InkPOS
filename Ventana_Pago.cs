using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Ventana_Pago : Form
    {
        private List<Productos> productosVendidos;
        private decimal totalVenta;
        private bool pagoConfirmado = false;

        public Ventana_Pago(List<Productos> productos, decimal total)
        {
            InitializeComponent();
            productosVendidos = productos;
            totalVenta = total;

            txtbox_valor.Text = totalVenta.ToString("C");
        }

        private void Ventana_Pago_Load(object sender, EventArgs e)
        {
            // Aquí puedes realizar inicialización si es necesario
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (box_metodopago.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            if (box_metodopago.SelectedItem.ToString() == "Efectivo")
            {
                if (!decimal.TryParse(txtbox_valorRecibido.Text, out decimal valorRecibido))
                {
                    MessageBox.Show("Ingrese un valor recibido válido.");
                    return;
                }

                if (valorRecibido < totalVenta)
                {
                    MessageBox.Show("El valor recibido es menor al total de la venta.");
                    return;
                }

                decimal cambio = valorRecibido - totalVenta;
                txtbox_cambio.Text = cambio.ToString("C");

                pagoConfirmado = true;
                MessageBox.Show("Pago confirmado.");
            }
        }

        private void button_finalizar_Click(object sender, EventArgs e)
        {
            if (!pagoConfirmado)
            {
                MessageBox.Show("Debe confirmar el pago antes de finalizar.");
                return;
            }

            MessageBox.Show("Pago finalizado y registrado exitosamente.");
            this.Close(); // Cierra la ventana de pago
        }

        private void button_generarPDF_Click(object sender, EventArgs e)
        {
            // Validación: asegurarse de que el pago fue confirmado
            if (!pagoConfirmado)  // usa una bandera que tú controles
            {
                MessageBox.Show("Debe confirmar el pago antes de generar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construir la lista de detalles de venta (aquí pones los datos reales de la venta)
            List<DetalleVenta> detallesVenta = new List<DetalleVenta>
    {
        new DetalleVenta { Codigo = "P001", Producto = "Mouse", Cantidad = 2, Valor = 50000 },
        new DetalleVenta { Codigo = "P002", Producto = "Teclado", Cantidad = 1, Valor = 70000 }
    };

            // Mostrar la factura
            InformeFactura frm = new InformeFactura(detallesVenta);
            frm.ShowDialog();  // o frm.Show() si no quieres bloquear
        }
    }
}
