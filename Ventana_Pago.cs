using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void button_aceptar_Click(object sender, EventArgs e)
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

        private void button_generarPDF_Click(object sender, EventArgs e)
        {
            if (!pagoConfirmado)
            {
                MessageBox.Show("Debe confirmar el pago antes de generar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir ventana de factura
           // Factura factura = new Factura(productosVendidos, totalVenta);
            //factura.ShowDialog();
        }
    }
}
