using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Agregar_producto : Form
    {
        private ProductoManager productoManager;

        public Form_Agregar_producto()
        {
            InitializeComponent();
            productoManager = new ProductoManager();  // Inicializar el manejador de productos
        }

        // Evento para el botón "Agregar"
        private void button_agregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string codigo = txtbox_codigoproducto.Text;
            string nombre = txtbox_nombreproducto.Text;
            decimal precio;
            int cantidad;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) ||
                !decimal.TryParse(txtbox_precio.Text, out precio) || !int.TryParse(txtbox_cantidad.Text, out cantidad))
            {
                MessageBox.Show("Todos los campos deben estar completos y ser válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo objeto Producto con los valores ingresados
            Producto nuevoProducto = new Producto
            {
                Codigo = codigo,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad
            };

            // Llamar al método de ProductoManager para agregar el producto
            string resultado = productoManager.AgregarProducto(nuevoProducto);

            // Mostrar el resultado (mensaje de éxito o error)
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos si el registro fue exitoso
            if (resultado == "Producto registrado correctamente.")
            {
                txtbox_codigoproducto.Clear();
                txtbox_nombreproducto.Clear();
                txtbox_precio.Clear();
                txtbox_cantidad.Clear();
            }
        }

        // Evento para el botón "Limpiar"
        private void button_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtbox_codigoproducto.Clear();
            txtbox_nombreproducto.Clear();
            txtbox_precio.Clear();
            txtbox_cantidad.Clear();
        }
    }
}
