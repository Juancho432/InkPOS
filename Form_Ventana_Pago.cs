using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Ventana_Pago : Form
    {
        private List<Producto> productosEnVenta;
        private decimal totalVenta;

        public Form_Ventana_Pago(List<Producto> productosEnVenta, decimal totalVenta)
        {
            this.productosEnVenta = productosEnVenta;
            this.totalVenta = totalVenta;
        }

        private void Ventana_Pago_Load(object sender, EventArgs e)
        {
            // Aquí puedes realizar inicialización si es necesario
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string valor_pagar = txtbox_valor.Text.Trim();
            string valor_recibido = txtbox_valorRecibido.Text.Trim();
            string metodo_pago = box_metodopago.Text.Trim();

            // Validar campos vacíos
            try
            {
                if (string.IsNullOrEmpty(valor_pagar) || string.IsNullOrEmpty(valor_recibido))
                {
                    // Lanzar la ventana de campos vacios
                    throw new Excepciones.CamposVacios();
                }
            }
            catch
            {
                return;
            }


            //DDBB 


        }

        private void button_finalizar_Click(object sender, EventArgs e)
        {

        }

        private void button_generarPDF_Click(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            // volver al inicio
            Form_Home_Empleado homeEmpleado = new();
            homeEmpleado.Show();
        }


        private void txtbox_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_valorRecibido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_cambio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
