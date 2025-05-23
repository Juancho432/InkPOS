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
    public partial class Form_Gestion_Productos : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        private List<Producto> productos;

        public Form_Gestion_Productos(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            productos = Database.ReadAllProducts();
            InitializeComponent();
            txtbox_buscar.TextChanged += txtbox_buscar_TextChanged;
            dgv_Productos.AutoGenerateColumns = false;
            AgregarColumnasAcciones();
        }

        private void AgregarColumnasAcciones()
        {
            // Evita duplicar columnas si el método se llama más de una vez
            if (!dgv_Productos.Columns.Contains("Editar"))
            {
                // Columna Editar
                DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
                colEditar.Name = "Editar";
                colEditar.HeaderText = "✏️";
                colEditar.Image = Properties.Resources.pen_square; // Ruta relativa
                colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Productos.Columns.Add(colEditar);
            }

            if (!dgv_Productos.Columns.Contains("Eliminar"))
            {
                // Columna Eliminar
                DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
                colEliminar.Name = "Eliminar";
                colEliminar.HeaderText = "🗑️";
                colEliminar.Image = Properties.Resources.icon_borrar;
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Productos.Columns.Add(colEliminar);
            }
        }

        private void Form_Gestion_Productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarDatosFiltrados(string filtro)
        {
            filtro = filtro.ToLower();
            var coincidencias = productos.Where(p =>
                p.Nombre.Contains(filtro, StringComparison.CurrentCultureIgnoreCase) ||
                p.Codigo.Contains(filtro, StringComparison.CurrentCultureIgnoreCase)).ToList();

            productoBindingSource.Clear();
            foreach (var producto in coincidencias)
            {
                productoBindingSource.Add(producto);
            }
        }


        private void button_añadir_producto_Click(object sender, EventArgs e)
        {
            Form_Agregar_Producto agregar_Producto = new(EmpleadoActual, Database);
            agregar_Producto.Show();
            Hide();
            agregar_Producto.FormClosed += (s, args) => {
                this.Show();
                CargarProductos(); // ← actualiza la vista
            };
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_buscar_TextChanged(object? sender, EventArgs e)
        {
            string filtro = txtbox_buscar.Text;
            CargarDatosFiltrados(filtro);
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            Producto productoSeleccionado = (Producto)dgv_Productos.Rows[e.RowIndex].DataBoundItem;
            string nombreColumna = dgv_Productos.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "Editar")
            {
                Form_Modificar_Producto modificar_Producto = new(EmpleadoActual, Database);
                modificar_Producto.Show();
                Hide();
                modificar_Producto.FormClosed += (s, args) => {
                    this.Show();
                    CargarProductos(); // ← actualiza la vista
                };
            }
            else if (nombreColumna == "Eliminar")
            {
                var confirm = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        bool eliminado = Database.DeleteProduct(productoSeleccionado);
                        if (eliminado)
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                            CargarProductos(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.");
                        }
                    }
                    catch (ProductoInexistente)
                    {
                        MessageBox.Show("El producto no existe o ya fue eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto:\n" + ex.Message);
                    }
                }
                dgv_Productos.ClearSelection();
            }
        }

        private void CargarProductos()
        {
            productos = Database.ReadAllProducts(); // ← recarga desde la base de datos
            productoBindingSource.Clear();
            foreach (var producto in productos)
            {
                productoBindingSource.Add(producto);
            }

            dgv_Productos.ClearSelection();
        }

        private void Form_Gestion_Productos_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null; // Desactivar cursor del txtbox
        }

        private void panelFondo_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dgv_Productos_Leave(object sender, EventArgs e)
        {
            dgv_Productos.ClearSelection();
        }

    }
}
