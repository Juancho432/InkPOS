using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_modificar_producto : Form
    {
        private ProductoManager productoManager;
        private Producto productoActual;

        public Form_modificar_producto(Producto producto)
        {
            InitializeComponent();
            productoManager = new ProductoManager();
            productoActual = producto;

            // Cargar los datos del producto en los controles
            box_campomodificar.Items.Add("Nombre");
            box_campomodificar.Items.Add("Precio");
            box_campomodificar.Items.Add("Cantidad");
            box_campomodificar.SelectedIndex = 0;

            // Mostrar los datos actuales
            txtbox_nuevovalor.Text = "";
        }

        // Evento para el botón "Confirmar"
        private void button_confirmar_Click(object sender, EventArgs e)
        {
            // Validar si se seleccionó un campo y se ingresó un nuevo valor
            string campoSeleccionado = box_campomodificar.SelectedItem?.ToString();
            string nuevoValorTexto = txtbox_nuevovalor.Text;

            if (string.IsNullOrWhiteSpace(nuevoValorTexto))
            {
                MessageBox.Show("El campo nuevo valor no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Modificar el producto según el campo seleccionado
            switch (campoSeleccionado)
            {
                case "Nombre":
                    productoActual.Nombre = nuevoValorTexto;
                    break;
                case "Precio":
                    if (decimal.TryParse(nuevoValorTexto, out decimal nuevoPrecio) && nuevoPrecio > 0)
                    {
                        productoActual.Precio = nuevoPrecio;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                case "Cantidad":
                    if (int.TryParse(nuevoValorTexto, out int nuevaCantidad) && nuevaCantidad >= 0)
                    {
                        productoActual.Cantidad = nuevaCantidad;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
            }

            // Guardar los cambios en el ProductoManager
            string resultado = productoManager.ModificarProducto(productoActual);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Si los cambios fueron guardados correctamente, cerrar la ventana
            if (resultado == "Cambios guardados correctamente.")
            {
                this.Close();
            }
        }

        // Evento para el botón "Cancelar"
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana sin realizar cambios
            this.Close();
        }
    }
}
