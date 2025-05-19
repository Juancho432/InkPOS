using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

            tabla_Productos.EditMode = DataGridViewEditMode.EditOnEnter;

            // Configura solo la columna de cantidad como editable
            foreach (DataGridViewColumn col in tabla_Productos.Columns)
                col.ReadOnly = col.Name != "column_cantidad";

            // Refuerza la configuración al mostrar el formulario
            this.Shown += (s, e) =>
            {
                foreach (DataGridViewColumn col in tabla_Productos.Columns)
                    col.ReadOnly = col.Name != "column_cantidad";
            };

            tabla_Productos.CellValidating += tabla_Productos_CellValidating;
            tabla_Productos.CellValueChanged += tabla_Productos_CellValueChanged;
            tabla_Productos.CellBeginEdit += tabla_Productos_CellBeginEdit;
            tabla_Productos.CellEndEdit += tabla_Productos_CellEndEdit;
            tabla_Productos.KeyDown += tabla_Productos_KeyDown;
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
                lista_Coincidencias.Items.Add(producto); // Agrega el objeto completo
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

        private void lista_Coincidencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && lista_Coincidencias.SelectedItem != null)
            {
                var productoSeleccionado = lista_Coincidencias.SelectedItem as Producto;
                if (productoSeleccionado != null)
                {
                    AgregarProductoATabla(productoSeleccionado);
                    MessageBox.Show($"Producto agregado: {productoSeleccionado.NombreItem}", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                e.Handled = true;
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
            int cantidad = 1;
            decimal valorTotal = producto.Precio * cantidad;
            tabla_Productos.Rows.Add(
                producto.IdProducto,      // column_codigo
                producto.NombreItem,      // column_NombreP
                cantidad,                 // column_cantidad
                valorTotal                // column_valor
            );
            ActualizarValorTotal();
        }

        // Guarda el valor anterior de cantidad para restaurar si la edición es inválida
        private object cantidadAnterior = null;

        private void tabla_Productos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (tabla_Productos.Columns[e.ColumnIndex].Name == "column_cantidad")
            {
                cantidadAnterior = tabla_Productos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void tabla_Productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_Productos.Columns["column_cantidad"] != null &&
                e.ColumnIndex == tabla_Productos.Columns["column_cantidad"].Index &&
                e.RowIndex >= 0)
            {
                DataGridViewRow fila = tabla_Productos.Rows[e.RowIndex];
                int cantidad = 1;
                if (fila.Cells["column_cantidad"].Value != null &&
                    int.TryParse(fila.Cells["column_cantidad"].Value.ToString(), out cantidad) &&
                    cantidad > 0)
                {
                    string id = fila.Cells["column_codigo"].Value?.ToString();
                    Producto producto = ProductosBaseDatos.FirstOrDefault(p => p.IdProducto == id);

                    decimal precioUnitario = producto?.Precio ?? 0;
                    if (producto == null && fila.Cells["column_valor"].Value != null && cantidad > 0)
                    {
                        decimal.TryParse(fila.Cells["column_valor"].Value.ToString(), out decimal valorActual);
                        precioUnitario = valorActual / cantidad;
                    }

                    fila.Cells["column_valor"].Value = precioUnitario * cantidad;
                    valor = Convert.ToInt32(fila.Cells["column_valor"].Value);
                }
            }
            ActualizarValorTotal();
        }

        private void tabla_Productos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cantidadAnterior = null;
            if (e.RowIndex >= 0 && e.RowIndex < tabla_Productos.Rows.Count)
                tabla_Productos.Rows[e.RowIndex].ErrorText = "";
        }


        private void txtbox_Cantidad_productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtbox_Cantidad_productos.Text, out int nuevaCantidad) && nuevaCantidad > 0)
                {
                    DataGridViewRow fila = null;

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
            int totalCantidad = 0;
            foreach (DataGridViewRow fila in tabla_Productos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Suma el valor total
                    if (fila.Cells["column_valor"].Value != null &&
                        decimal.TryParse(fila.Cells["column_valor"].Value.ToString(), out decimal valorFila))
                    {
                        total += valorFila;
                    }
                    // Suma la cantidad total
                    if (fila.Cells["column_cantidad"].Value != null &&
                        int.TryParse(fila.Cells["column_cantidad"].Value.ToString(), out int cantidadFila))
                    {
                        totalCantidad += cantidadFila;
                    }
                }
            }
            txtbox_Valor_total.Text = total.ToString("N2");
            txtbox_Cantidad_productos.Text = totalCantidad.ToString();
        }

        private void Form_Venta_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in tabla_Productos.Columns)
            {
                col.ReadOnly = col.Name != "column_cantidad";
            }
        }

        private void tabla_Productos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // No validar la fila de nueva inserción
            if (tabla_Productos.Rows[e.RowIndex].IsNewRow)
                return;

            if (tabla_Productos.Columns[e.ColumnIndex].Name == "column_cantidad")
            {
                string value = e.FormattedValue?.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(value) || !int.TryParse(value, out int cantidad) || cantidad <= 0)
                {
                    tabla_Productos.Rows[e.RowIndex].ErrorText = "La cantidad debe ser un número entero mayor a 0.";
                    e.Cancel = true;
                }
                else
                {
                    tabla_Productos.Rows[e.RowIndex].ErrorText = "";
                }
            }
            else
            {
                tabla_Productos.Rows[e.RowIndex].ErrorText = "";
            }
        }


        private void tabla_Productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabla_Productos.IsCurrentCellInEditMode)
            {
                tabla_Productos.EndEdit();
                e.Handled = true;
            }
        }

        private void lista_Coincidencias_DoubleClick(object sender, EventArgs e)
        {
            if (lista_Coincidencias.SelectedItem is Producto productoSeleccionado)
            {
                AgregarProductoATabla(productoSeleccionado);
                MessageBox.Show($"Producto agregado: {productoSeleccionado.NombreItem}", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //agregar consulta sql para buscar cliente por id o nombre
        private void txtbox_buscar_cliente_TextChanged(object sender, EventArgs e)
        {
        //    string texto = txtbox_buscar_cliente.Text.Trim();
        //    if (string.IsNullOrEmpty(texto))
        //    {
        //        txtbox_nombre_cliente.Text = "";
        //        return;
        //    }

        //    var cliente = Database.ReadClientByIdOrName(texto);
        //    if (cliente != null)
        //        txtbox_nombre_cliente.Text = cliente.Nombre;
        //    else
        //        txtbox_nombre_cliente.Text = "";
        }

    }
}
