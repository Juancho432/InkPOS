using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Agregar_producto : Form
    {
        public agregar_producto()
        {
            InitializeComponent();
        }

        // Evento para el botón "Agregar"
        private void button_agregar_Click(object sender, EventArgs e)
        {
            //Obtener los valores de los textbox

            string nombre_producto = txtbox_nombreproducto.Text.Trim();
            string codigo_producto = txtbox_codigoproducto.Text.Trim();
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

            //BBDD

            //Producto productoNuevo;

            ////if (productoNuevo != null)
            //{
            //    //Creacion de producto exitosa
            //    MessageBox.Show("El producto fue ingresado al sistema exitosamente");




            //    Hide();
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
