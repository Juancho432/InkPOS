using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InkPos.Excepciones;

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
            try
            {
                string idFactura = txtbox_ID_factura.Text.Trim();
                string codigoProducto = txtbox_codigo_producto.Text.Trim();
                if (!int.TryParse(txtbox_cantidad_producto.Text.Trim(), out int cantidadDevolver) || cantidadDevolver <= 0)
                {
                    MessageBox.Show("La cantidad a devolver debe ser un número positivo.");
                    return;
                }

                // Paso 1: Leer la factura
                Factura factura = Database.ReadInvoiceByID(idFactura);

                // Paso 2: Buscar el detalle del producto
                var detalle = factura.Detalles.FirstOrDefault(d => d.Producto.Codigo == codigoProducto);
                if (detalle == null)
                {
                    MessageBox.Show("El producto no está en la factura.");
                    return;
                }

                // Paso 3: Validar que no se devuelva más cantidad de la vendida
                if (cantidadDevolver > detalle.Cantidad)
                {
                    MessageBox.Show("No puedes devolver más cantidad de la que se vendió.");
                    return;
                }


                // Paso 6: Registrar la devolución
                bool exito = Database.CreateRefund(idFactura, codigoProducto);
                if (exito)
                {
                    MessageBox.Show("Devolución registrada y stock actualizado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la devolución.");
                }

                // Paso 5: Actualizar el stock
                Producto producto = detalle.Producto;
                producto.Stock += cantidadDevolver;


                //Conexion con BBDD - ACTUALIZAR STOCK NUEVAMENTE LUEGO DE LA DEVOLUCION
                try
                {
                    Database.UpdateProduct(producto);
                }
                catch
                {
                    return;
                }

            }
            catch (FacturaInexistente)
            {
                MessageBox.Show("La factura ingresada no existe.");
            }
            catch (DevolucionExistente)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
