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
    public partial class Form_Agregar_Producto : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Agregar_Producto(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los textbox
            string nombre_producto = txtbox_add_nombre_producto.Text.Trim();
            string codigo_producto = txtbox_add_codigo_producto.Text.Trim();
            string cantidad = txtbox_add_cantidad.Text.Trim();
            string precio = txtbox_add_precio.Text.Trim();

            // Validar campos vacíos
            try
            {
                if (string.IsNullOrEmpty(nombre_producto) ||
                    string.IsNullOrEmpty(codigo_producto) ||
                    string.IsNullOrEmpty(cantidad) ||
                    string.IsNullOrEmpty(precio))
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch 
            {
                return;
            }

            // Parsear los valores numéricos
            if ( !int.TryParse(cantidad, out int stock) ||
                !decimal.TryParse(precio, out decimal pvp))
            {
                MessageBox.Show("Verifica que la cantidad y el precio sean valores numéricos válidos.");
                return;
            }

            // Crear objeto producto
            Producto productoNuevo = new(codigo_producto, nombre_producto, pvp, stock);


            //BBDD

            // Verificar si el producto ya existe por su código
            try
            {
                Database.CreateProduct(productoNuevo);
            }
            catch
            {
                return;
            }

            MessageBox.Show("Producto ingresado correctamente.");
            Hide(); // Oculta el formulario
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_add_nombre_producto.Clear();
            txtbox_add_codigo_producto.Clear();
            txtbox_add_cantidad.Clear();
            txtbox_add_precio.Clear();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
