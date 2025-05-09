using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Agregar_producto : Form
    {
        public Form_Agregar_producto()
        {
            InitializeComponent();
        }

        // Evento para el botón "Agregar"
        private void button_agregar_Click(object sender, EventArgs e)
        {
            //Obtener los valores de los textbox

            string nombre_producto = txtbox_nombreproducto.Text.Trim();
            string codigo_producto = (txtbox_codigoproducto.Text.Trim());
            string cantidad = txtbox_cantidad.Text.Trim();
            string precio = txtbox_precio.Text.Trim();

            //Validacion de campos vacios 

            // Validar campos vacíos
            try
            {
                if (string.IsNullOrEmpty(nombre_producto) || string.IsNullOrEmpty(codigo_producto)
                   || string.IsNullOrEmpty(cantidad) || string.IsNullOrEmpty(precio))

                {
                    // Lanzar la ventana de campos vacios
                    throw new Excepciones.CamposVacios();
                }
            }
            catch
            {
                return;
            }

            // Parsear los valores numéricos
            if (!int.TryParse(cantidad, out int stock) ||
                !decimal.TryParse(precio, out decimal pvp))
            {
                MessageBox.Show("Verifica que el código, cantidad y precio sean valores numéricos válidos.");
                return;
            }

            
            Producto productoNuevo = new Producto(codigo, nombre_producto, stock, pvp);


            // Verificar si el producto ya existe por su código
            //if (db.ExisteProductoPorCodigo(codigo))
            //{
            //    MessageBox.Show("Ya existe un producto con ese código.");
            //    return;
            //}

            //// Insertar producto en la base de datos
            //bool exito = db.InsertarProducto(productoNuevo);

            //if (exito)
            //{
            //    MessageBox.Show("Producto ingresado correctamente.");
            //    this.Hide(); // Oculta el formulario
            //}
            //else
            //{
            //    MessageBox.Show("Error al ingresar el producto.");
            //}
            
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

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
