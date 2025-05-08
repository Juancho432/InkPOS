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

        private List<Producto> productosEnVenta = new List<Producto>();
        private decimal totalVenta = 0;
        public Form_Venta()
        {
            InitializeComponent();
            // Asocia el evento DoubleClick al método que se encarga de agregar el producto al DataGridView
            this.lstCoincidencias.DoubleClick += new System.EventHandler(this.lstCoincidencias_DoubleClick);
            this.lstCoincidencias.KeyDown += new KeyEventHandler(this.lstCoincidencias_KeyDown);
            this.dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            this.txtBusqueda.KeyDown += new KeyEventHandler(this.txtBusqueda_KeyDown);
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            // Configurar columnas del DataGridView manualmente
            dgvProductos.ColumnCount = 4;
            dgvProductos.Columns[0].Name = "ID";
            dgvProductos.Columns[1].Name = "Producto";
            dgvProductos.Columns[2].Name = "Cantidad";
            dgvProductos.Columns[3].Name = "Valor";
        }

        private void lstCoincidencias_DoubleClick(object sender, EventArgs e)
        {
            AgregarProductoSeleccionado(false);
        }

        private void lstCoincidencias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                AgregarProductoSeleccionado(true); // con cantidad
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AgregarProductoSeleccionado(false); // sin cantidad
            }
        }

        private void AgregarProductoSeleccionado(bool preguntarCantidad)
        {
            if (lstCoincidencias.SelectedItem == null)
                return;

            Producto producto = (Producto)lstCoincidencias.SelectedItem;

            int cantidad = 1;

            if (preguntarCantidad)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad:", "Cantidad", "1");

                if (!int.TryParse(input, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Cantidad no válida.");
                    return;
                }

                if (cantidad > producto.Stock)
                {
                    MessageBox.Show("No hay suficiente stock.");
                    return;
                }
            }

            // Verifica si ya está en el DataGridView
            bool yaExiste = false;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells[0].Value != null && (int)fila.Cells[0].Value == producto.IdProducto)
                {
                    int cantidadActual = Convert.ToInt32(fila.Cells[2].Value);
                    int nuevaCantidad = cantidadActual + cantidad;

                    if (nuevaCantidad > producto.Stock)
                    {
                        MessageBox.Show("Supera el stock disponible.");
                        return;
                    }

                    fila.Cells[2].Value = nuevaCantidad;
                    fila.Cells[3].Value = producto.Pvp * nuevaCantidad;

                    totalVenta += producto.Pvp * cantidad;
                    txtValorTotal.Text = totalVenta.ToString("C");
                    yaExiste = true;
                    break;
                }
            }

            if (!yaExiste)
            {
                dgvProductos.Rows.Add(producto.IdProducto, producto.NombreItem, cantidad, producto.Pvp * cantidad);
                totalVenta += producto.Pvp * cantidad;
                txtValorTotal.Text = totalVenta.ToString("C");
            }

            productosEnVenta.Add(producto);

            // 🔄 Actualiza el total de productos agregados
            ActualizarCantidadTotal();
        }


        private void ActualizarCantidadTotal()
        {
            int totalCantidad = 0;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells[2].Value != null)
                {
                    totalCantidad += Convert.ToInt32(fila.Cells[2].Value);
                }
            }

            txtboxCantidadProducto.Text = totalCantidad.ToString();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Columna "Cantidad"
            {
                var fila = dgvProductos.Rows[e.RowIndex];

                int cantidadActual = 0;
                if (fila.Cells[2].Value != null)
                {
                    cantidadActual = Convert.ToInt32(fila.Cells[2].Value);
                }

                int idProducto = Convert.ToInt32(fila.Cells[0].Value);


                var producto = productoDatos.ObtenerProductoPorId(idProducto);

                // Verificar si el producto no se encontró
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return; // Salir de la función si no se encuentra el producto
                }

                string input = Microsoft.VisualBasic.Interaction.InputBox("Modificar cantidad:", "Cantidad", cantidadActual.ToString());

                if (!int.TryParse(input, out int nuevaCantidad) || nuevaCantidad <= 0)
                {
                    MessageBox.Show("Cantidad no válida.");
                    return;
                }

                // Verificar stock
                if (nuevaCantidad > producto.Stock)
                {
                    MessageBox.Show("No hay suficiente stock.");
                    return;
                }

                // Actualizar valores
                fila.Cells[2].Value = nuevaCantidad;
                fila.Cells[3].Value = producto.Pvp * nuevaCantidad;

                RecalcularTotalVenta();
                ActualizarCantidadTotal();
            }
        }



        private void RecalcularTotalVenta()
        {
            totalVenta = 0;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells[3].Value != null)
                    totalVenta += Convert.ToDecimal(fila.Cells[3].Value);
            }

            txtValorTotal.Text = totalVenta.ToString("C");
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica si la tecla presionada es Enter
            {
                btnBuscar_Click(sender, e); // Llama al evento click del botón de búsqueda
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_valorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void busqueda_productos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Por favor ingresa un nombre o ID de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar productos
            List<Producto> productos = productoDatos.BuscarProductos(criterio);

            // Limpiar resultados anteriores
            lstCoincidencias.Items.Clear();

            if (productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar resultados SOLO en el ListBox
            foreach (var prod in productos)
            {
                lstCoincidencias.Items.Add(prod); // ToString ya muestra nombre y stock
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (productosEnVenta.Count == 0)
            {
                MessageBox.Show("No hay productos agregados.");
                return;
            }

            // Aquí podrías guardar en base de datos o pasar a otro formulario
            MessageBox.Show("Venta finalizada. Total: " + txtValorTotal.Text);

            // Limpiar
            productosEnVenta.Clear();
            dgvProductos.Rows.Clear();
            totalVenta = 0;
            txtValorTotal.Text = "";


            Form_Ventana_Pago pago = new Form_Ventana_Pago(productosEnVenta, totalVenta);
            pago.ShowDialog();
        }

        private void busqueda_productos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
