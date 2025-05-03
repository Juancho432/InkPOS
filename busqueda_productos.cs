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
    public partial class busqueda_productos : Form
    {

        private ProductosDatos productosDatos = new ProductosDatos();
        public busqueda_productos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            // Configurar columnas del DataGridView manualmente
            dgvDetallesProducto.ColumnCount = 4;
            dgvDetallesProducto.Columns[0].Name = "ID";
            dgvDetallesProducto.Columns[1].Name = "Producto";
            dgvDetallesProducto.Columns[2].Name = "Cantidad";
            dgvDetallesProducto.Columns[3].Name = "Valor";
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
            string criterio = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Por favor ingresa un nombre o ID de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar productos
            List<Productos> productos = productosDatos.BuscarProductos(criterio);

            // Limpiar resultados anteriores
            lstResultados.Items.Clear();
            dgvDetallesProducto.Rows.Clear();

            if (productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar resultados
            foreach (var prod in productos)
            {
                // ListBox muestra el nombre
                lstResultados.Items.Add(prod.NombreItem);

                // DataGridView muestra los detalles
                dgvDetallesProducto.Rows.Add(prod.IdProducto, prod.NombreItem, prod.Stock, prod.Pvp);
            }
        }
    }
}
