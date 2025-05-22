using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Venta : Form
    {
        private readonly Empleado EmpleadoActual;
        private readonly DataBaseHandler Database;
        private readonly List<Producto> productos;

        public int ValorTotal { get; private set; }

        public Form_Venta(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            productos = Database.ReadAllProducts();
            InitializeComponent();
        }

        private void Boton_Finalizar_Click(object sender, EventArgs e)
        {
            /*
            List<Producto> productos = new List<Producto>();
            foreach (DataGridViewRow fila in tabla_Productos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Producto producto = new Producto(
                        fila.Cells["column_codigo"].Value?.ToString(),
                        fila.Cells["column_NombreP"].Value?.ToString(),
                        Convert.ToDecimal(fila.Cells["column_valor"].Value),
                        Convert.ToInt32(fila.Cells["column_cantidad"].Value)
                    );
                    productos.Add(producto);
                }
            }

            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos en la tabla para finalizar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal valorTotal = 0;
            if (!decimal.TryParse(txtbox_Valor_total.Text, out valorTotal))
            {
                MessageBox.Show("Ingrese un valor total válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form_Ventana_Pago ventanaPago = new(Database, );
            ventanaPago.ShowDialog();
            Close();
            */
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int ObtenerSimilitud(string texto1, string texto2)
        {
            int coincidencias = 0;
            int longitud = Math.Min(texto1.Length, texto2.Length);
            for (int i = 0; i < longitud; i++)
            {
                if (texto1[i] == texto2[i])
                    coincidencias++;
            }
            return coincidencias;
        }

        // Guarda el valor anterior de cantidad para restaurar si la edición es inválida
        private object cantidadAnterior = null;

        private void Tabla_Productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            ActualizarValorTotal();
        }

        private void ActualizarValorTotal()
        {
            decimal valorTotal = 0;
            int cantidadTotal = 0;

            foreach (DetalleVenta item in detalleVentaBindingSource.List)
            {
                valorTotal += item.Subtotal;
                cantidadTotal += item.Cantidad;
            }

            txtbox_Valor_total.Text = valorTotal.ToString("N2");
            txtbox_Cantidad_productos.Text = cantidadTotal.ToString();
        }

        private void Txtbox_buscar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string texto = txtbox_buscar_cliente.Text.Trim();
                    Cliente cliente = Database.ReadClientByID(texto);
                    txtbox_nombre_cliente.Text = cliente.NombreCliente;
                }
                catch
                {
                    return;
                }
            }
        }

        private void Form_Venta_Load(object sender, EventArgs e)
        {
            foreach (Producto item in productos)
            {
                productoBindingSource.Add(item);
            }
        }

        private void Txtbox_busqueda_producto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbox_busqueda_producto.Text.ToLower();
            List<Producto> coincidencias = [.. productos.Where(p =>
                                            p.Nombre.Contains(filtro, StringComparison.CurrentCultureIgnoreCase) ||
                                            p.Codigo.Contains(filtro, StringComparison.CurrentCultureIgnoreCase))];

            productoBindingSource.List.Clear();
            foreach (Producto item in coincidencias)
            {
                productoBindingSource.Add(item);
            }
        }

        private void DG_Busqueda_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto seleccion = (Producto)productoBindingSource.List[e.RowIndex]!;
            bool encontrado = false;
            foreach (DetalleVenta item in detalleVentaBindingSource.List)
            {
                if (item.Producto.Codigo == seleccion.Codigo)
                {
                    item.Cantidad++;
                    detalleVentaBindingSource.ResetBindings(false);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                DetalleVenta nuevoDetalle = new(seleccion, 1);
                detalleVentaBindingSource.Add(nuevoDetalle);
            }
            ActualizarValorTotal();
        }
    }
}
