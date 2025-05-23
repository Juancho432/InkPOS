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
    public partial class Form_Devolucion : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        public Form_Devolucion(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            string idFacturaStr = txtbox_ID_factura.Text.Trim();
            string codigoProducto = txtbox_codigo_producto.Text.Trim();
            string cantidadStr = txtbox_cantidad_producto.Text.Trim();

            if (string.IsNullOrEmpty(idFacturaStr) || string.IsNullOrEmpty(codigoProducto) || string.IsNullOrEmpty(cantidadStr))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            if (!long.TryParse(idFacturaStr, out long idFactura) || !int.TryParse(cantidadStr, out int cantidadDevolver))
            {
                MessageBox.Show("ID de factura y cantidad deben ser números válidos.");
                return;
            }

            if (cantidadDevolver <= 0)
            {
                MessageBox.Show("La cantidad a devolver debe ser mayor que cero.");
                return;
            }

            //Conexion con BBDD

            // Buscar la factura
            //Factura factura = Database.GetFacturaById(idFactura);
            //if (factura == null)
            //{
            //    MessageBox.Show("Factura no encontrada.");
            //    return;
            //}

            // Buscar el producto en los detalles de la factura
            //var detalle = factura.Detalles.FirstOrDefault(d => d.Producto.Codigo == codigoProducto);
            //if (detalle == null)
            //{
            //    MessageBox.Show("El producto no está en la factura.");
            //    return;
            //}

            //if (cantidadDevolver > detalle.Cantidad)
            //{
            //    MessageBox.Show("No puedes devolver más de lo que se vendió.");
            //    return;
            //}

            //Conexion con BBDD

            // Obtener el producto actual
            //Producto producto = Database.GetProductoById(codigoProducto);
            //if (producto == null)
            //{
            //    MessageBox.Show("Producto no encontrado.");
            //    return;
            //}

            // Actualizar el stock
            //int nuevoStock = producto.Stock + cantidadDevolver;
            //bool actualizado = Database.UpdateProductoStock(codigoProducto, nuevoStock);

            //if (actualizado)
            //{
            //    MessageBox.Show("Devolución procesada exitosamente.");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Error al actualizar el stock del producto.");
            //}

        }
    }
}
