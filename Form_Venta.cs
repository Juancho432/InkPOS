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
    public partial class Form_Venta : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        private List<Producto> ProductosBaseDatos;
        private int valor;

        public int ValorTotal { get; private set; }

        public Form_Venta(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
            crear_Lista_Productos();
        }
        public void crear_Lista_Productos()
        {
            ProductosBaseDatos = ObtenerListaProductos();
        }

        private void button_finalizar_Click(object sender, EventArgs e)
        {
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

    // Obtener el valor total desde el textbox
    decimal valorTotal = 0;
    if (!decimal.TryParse(txtbox_Valor_total.Text, out valorTotal))
    {
        MessageBox.Show("Ingrese un valor total válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

            Form_Ventana_Pago ventanaPago = new Form_Ventana_Pago(EmpleadoActual, Database, productos, (int)valorTotal);
    ventanaPago.ShowDialog();
    this.Close();
}


        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_busqueda_producto_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtbox_busqueda_producto.Text.ToLower();
            var coincidencias = ProductosBaseDatos
                .Where(p => p.NombreItem.ToLower().Contains(textoBusqueda) || p.IdProducto.ToLower().Contains(textoBusqueda))
                .OrderByDescending(p => ObtenerSimilitud(p.NombreItem.ToLower(), textoBusqueda))
                .ThenByDescending(p => ObtenerSimilitud(p.IdProducto.ToLower(), textoBusqueda))
                .ToList();

            lista_Coincidencias.Items.Clear();
            foreach (var producto in coincidencias)
            {
                string item = $"ID: {producto.IdProducto} | Nombre: {producto.NombreItem}";
                lista_Coincidencias.Items.Add(item);
            }
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

        private List<Producto> ObtenerListaProductos()
        {
            // Aquí se realiza la consulta a la base de datos
            // SELECT * FROM Producto;
            return Database.ReadAllProducts();
        }

        private void txtbox_busqueda_producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string textoBusqueda = txtbox_busqueda_producto.Text.ToLower().Trim();
                Producto productoEncontrado = ProductosBaseDatos
                    .FirstOrDefault(p => p.NombreItem.ToLower() == textoBusqueda || p.IdProducto.ToLower() == textoBusqueda);

                if (productoEncontrado != null)
                {
                    AgregarProductoATabla(productoEncontrado);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto buscado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void AgregarProductoATabla(Producto producto)
        {
            foreach (DataGridViewRow fila in tabla_Productos.Rows)
            {
                if (fila.Cells["column_codigo"].Value?.ToString() == producto.IdProducto)
                {
                    MessageBox.Show("El producto ya está en la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            tabla_Productos.Rows.Add(
                producto.IdProducto,
                producto.NombreItem,
                1,
                producto.Precio
            );
            ActualizarValorTotal();
        }

        private void tabla_Productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_Productos.Columns["column_cantidad"] != null &&
                e.ColumnIndex == tabla_Productos.Columns["column_cantidad"].Index &&
                e.RowIndex >= 0)
            {
                DataGridViewRow fila = tabla_Productos.Rows[e.RowIndex];
                if (int.TryParse(fila.Cells["column_cantidad"].Value?.ToString(), out int cantidad))
                {
                    if (cantidad == 0)
                    {
                        tabla_Productos.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("El producto ha sido eliminado de la tabla porque la cantidad es 0.", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Obtener el stock del producto con la base de datos
                    string id = fila.Cells["column_codigo"].Value?.ToString();
                    Producto producto = ProductosBaseDatos.FirstOrDefault(p => p.IdProducto == id);
                    int stock = producto?.Stock ?? 0;

                    if (cantidad > stock)
                    {
                        MessageBox.Show($"La cantidad no puede ser mayor al stock disponible ({stock}).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fila.Cells["column_cantidad"].Value = stock;
                        cantidad = stock;
                        if (stock == 0)
                        {
                            tabla_Productos.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("El producto ha sido eliminado de la tabla porque no hay stock de este producto.", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Calcular el nuevo total
                    decimal precioUnitario = producto?.Precio ?? 0;
                    fila.Cells["column_valor"].Value = precioUnitario * cantidad;
                    valor = Convert.ToInt32(fila.Cells["column_valor"].Value);
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fila.Cells["column_cantidad"].Value = 1;
                    string id = fila.Cells["column_codigo"].Value?.ToString();
                    Producto producto = ProductosBaseDatos.FirstOrDefault(p => p.IdProducto == id);
                    decimal precioUnitario = producto?.Precio ?? 0;
                    fila.Cells["column_valor"].Value = precioUnitario;
                }
            }
            ActualizarValorTotal();
        }

        private void lista_Coincidencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            // KeyPressEventArgs does not have a KeyCode property. Use KeyDown or KeyUp event instead.
            // Replace this method with the KeyDown event handler to properly handle the Enter key.

            if (e.KeyChar == (char)Keys.Enter) // Check if the pressed key is Enter
            {
                string textoBusqueda = txtbox_busqueda_producto.Text.ToLower();
                Producto productoEncontrado = null;

                foreach (var producto in ProductosBaseDatos)
                {
                    if (producto.NombreItem.ToLower() == textoBusqueda || producto.IdProducto.ToLower() == textoBusqueda)
                    {
                        productoEncontrado = producto;
                        break;
                    }
                }

                if (productoEncontrado != null)
                {
                    AgregarProductoATabla(productoEncontrado);
                    MessageBox.Show($"Producto agregado: {productoEncontrado.NombreItem}", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto buscado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Prevent the 'ding' sound when pressing Enter
                e.Handled = true;
            }
        }

        private void txtbox_Cantidad_productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtbox_Cantidad_productos.Text, out int nuevaCantidad) && nuevaCantidad > 0)
                {
                    DataGridViewRow fila = null;

                    // Prioriza la fila seleccionada, si no, usa la fila de la celda activa
                    if (tabla_Productos.SelectedRows.Count > 0)
                    {
                        fila = tabla_Productos.SelectedRows[0];
                    }
                    else if (tabla_Productos.CurrentCell != null)
                    {
                        fila = tabla_Productos.Rows[tabla_Productos.CurrentCell.RowIndex];
                    }

                    if (fila != null && !fila.IsNewRow)
                    {
                        fila.Cells["column_cantidad"].Value = nuevaCantidad;
                        // Forzar commit para disparar CellValueChanged
                        tabla_Productos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un producto válido en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtbox_Cantidad_productos.SelectAll();
                e.Handled = true;
            }
        }
        private void ActualizarValorTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in tabla_Productos.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["column_valor"].Value != null)
                {
                    if (decimal.TryParse(fila.Cells["column_valor"].Value.ToString(), out decimal valorFila))
                    {
                        total += valorFila;
                    }
                }
            }
            txtbox_Valor_total.Text = total.ToString("N2");
        }

    }
}


