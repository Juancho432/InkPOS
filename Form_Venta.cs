using System.Data;

namespace InkPos
{
    public partial class Form_Venta : Form
    {
        private readonly Empleado EmpleadoActual;
        private readonly DataBaseHandler Database;
        private readonly List<Producto> Productos;
        private Cliente? ClienteActual;
        private decimal ValorTotal;
        public Form_Venta(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            Productos = Database.ReadAllProducts();
            InitializeComponent();
        }

        private void Boton_Finalizar_Click(object sender, EventArgs e)
        {
            if (ClienteActual == null)
            {
                MessageBox.Show("Debe ingresar un cliente antes de continuar.",
                                "Cliente Invalido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detalleVentaBindingSource.List.Count == 0)
            {
                MessageBox.Show("No hay productos agregados a la factura.",
                                "Factura Vacia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<DetalleVenta> detallesFactura = [];
            foreach (DetalleVenta detalle in detalleVentaBindingSource.List)
            {
                detallesFactura.Add(detalle);
            }

            Factura nuevaFactura = new(ClienteActual.IdCliente, EmpleadoActual.Id_Empleado,
                ValorTotal, detallesFactura);

            Form_Ventana_Pago pagos = new(Database, nuevaFactura, EmpleadoActual, ClienteActual);
            pagos.Show();
            Hide();
            pagos.FormClosed += (s, e) => Show();
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            ValorTotal = valorTotal;
        }

        private void Txtbox_buscar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string texto = txtbox_buscar_cliente.Text.Trim();
                    ClienteActual = Database.ReadClientByID(texto);
                    txtbox_nombre_cliente.Text = ClienteActual.NombreCliente;
                }
                catch
                {
                    return;
                }
            }
        }

        private void Form_Venta_Load(object sender, EventArgs e)
        {
            foreach (Producto item in Productos)
            {
                productoBindingSource.Add(item);
            }
        }

        private void Txtbox_busqueda_producto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbox_busqueda_producto.Text.ToLower();
            List<Producto> coincidencias = [.. Productos.Where(p =>
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
            if (seleccion.Stock == 0)
            {
                MessageBox.Show("No existe stock del producto.",
                                "Stock insuficiente",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DetalleVenta item in detalleVentaBindingSource.List)
            {
                if (item.Producto.Codigo == seleccion.Codigo)
                {
                    if (item.Cantidad + 1 > item.Producto.Stock)
                    {
                        MessageBox.Show("No se puede agregar mas producto que el stock existente.",
                                "Stock insuficiente",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        item.Cantidad++;
                        detalleVentaBindingSource.ResetBindings(false);
                    }
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

        private void DG_Detalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int nuevoValor;
                if (e.FormattedValue == null)
                {
                    MessageBox.Show("No se puede dejar el campo vacio",
                                    "Cantidad Invalida",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    return;
                }
                else
                {
                    nuevoValor = int.Parse(e.FormattedValue.ToString()!);
                }

                DetalleVenta detalleModificado = (DetalleVenta)detalleVentaBindingSource.List[e.RowIndex]!;

                if (nuevoValor < 0)
                {
                    MessageBox.Show("No se puede poner cantidades negativas",
                                    "Cantidad Invalida",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    return;
                }

                if (nuevoValor > detalleModificado.Producto.Stock)
                {
                    MessageBox.Show("No se puede agregar mas producto que el stock existente.",
                                    "Cantidad Invalida",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    return;
                } 
            }
            else
            {
                return;
            }
        }
    }
}
