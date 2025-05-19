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
    public partial class Form_Ventana_Pago : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        private int Valor;
        private List<Producto> Productos;
        private string? valorRecibido;

        public Form_Ventana_Pago(Empleado empleado, DataBaseHandler database, List<Producto> productos, int ValorTotal)
        {
            EmpleadoActual = empleado;
            Database = database;
            Productos = productos ?? new List<Producto>();
            Valor = ValorTotal; // Asigna el valor recibido a la variable de instancia
            InitializeComponent();

            txtbox_valor.Text = ValorTotal.ToString("N2"); // Asigna el valor al textbox
            InicializarFormulario();
        }
        private void InicializarFormulario()
        {

            // Ocultar los controles relacionados con el pago por Transacción
            lbl_valor_recibido.Visible = true;
            txtbox_valor_recibido.Visible = true;
            lbl_cambio.Visible = true;
            txtbox_cambio.Visible = true;

            // Cambiar el texto de lbl_valor_recibido
            lbl_valor_recibido.Text = "Valor recibido";

            // Agregar las opciones al ComboBox CB_transaccion
            CB_transaccion.DropDownStyle = ComboBoxStyle.DropDownList;

            CB_transaccion.Items.Clear(); // Limpiar cualquier elemento previo
            CB_transaccion.Items.Add("Efectivo");
            CB_transaccion.Items.Add("Transacción");

            CB_transaccion.SelectedIndex = 0; // Selecciona "Efectivo" por defecto

        }
        private void txtbox_valor_recibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Verificar si la opción seleccionada en CB_transaccion es "Efectivo"
                if (CB_transaccion.SelectedItem != null && CB_transaccion.SelectedItem.ToString() == "Efectivo")
                {
                    CalcularCambio();
                }
                else
                {
                    string codigoTransferencia = txtbox_valor_recibido.Text;
                }
            }
        }
        private void CalcularCambio()
        {
            // Verificar que los valores de los TextBox no estén vacíos
            if (string.IsNullOrEmpty(txtbox_valor_recibido.Text) || string.IsNullOrEmpty(txtbox_valor.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos valores: el precio de la compra y el dinero recibido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar convertir los valores a números decimales
            if (decimal.TryParse(txtbox_valor_recibido.Text, out decimal valorRecibido) &&
                decimal.TryParse(txtbox_valor.Text, out decimal valorCompra))
            {
                // Calcular el cambio
                decimal cambio = valorRecibido - valorCompra;

                // Verificar si el dinero recibido es suficiente
                if (cambio < 0)
                {
                    MessageBox.Show("El dinero recibido no es suficiente para cubrir el precio de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox_cambio.Text = "0.00";
                }
                else
                {
                    // Asignar el cambio al TextBox correspondiente
                    txtbox_cambio.Text = cambio.ToString("F2");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_transaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_transaccion.SelectedItem != null)
            {
                string seleccion = CB_transaccion.SelectedItem.ToString();

                if (seleccion == "Efectivo")
                {
                    // Mostrar controles relacionados con el pago en efectivo
                    lbl_valor_recibido.Visible = true;
                    txtbox_valor_recibido.Visible = true;
                    lbl_cambio.Visible = true;
                    txtbox_cambio.Visible = true;

                    // Cambiar el texto de lbl_valor_recibido
                    lbl_valor_recibido.Text = "Valor recibido";
                }
                else if (seleccion == "Transacción")
                {
                    // Mostrar solo lbl_valor_recibido y txtbox_valor_recibido
                    lbl_valor_recibido.Visible = true;
                    txtbox_valor_recibido.Visible = true;

                    // Ocultar controles relacionados con el cambio
                    lbl_cambio.Visible = false;
                    txtbox_cambio.Visible = false;

                    // Cambiar el texto de lbl_valor_recibido
                    lbl_valor_recibido.Text = "Código de la transferencia";
                }
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_valor_recibido_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener los valores de los textboxes
                if (decimal.TryParse(txtbox_valor_recibido.Text, out decimal valorRecibido) &&
                    decimal.TryParse(txtbox_valor.Text, out decimal valorTotal))
                {
                    decimal cambio = valorRecibido - valorTotal;
                    txtbox_cambio.Text = cambio.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;
            }
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar campo vacío
                if (string.IsNullOrWhiteSpace(txtbox_valor_recibido.Text))
                {
                    throw new Excepciones.CamposVacios();
                }

                // Aquí continúa la lógica para guardar la factura, etc.
            }
            catch (Excepciones.CamposVacios)
            {
             
                return;
            }
            //Tomar los datos de la factura y subirlo a la base de datos
        }
    }
}