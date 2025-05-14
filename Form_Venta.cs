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
        { // Crear una lista de productos a partir de la tabla
            List<Producto> productos = new List<Producto>();

            foreach (DataGridViewRow fila in tabla_Productos.Rows)
            {
                if (!fila.IsNewRow) // Ignorar la fila nueva vacía
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

            // Validar que la lista no esté vacía
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos en la tabla para finalizar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva instancia de Form_Ventana_Pago con la lista de productos
            Form_Ventana_Pago ventanaPago = new Form_Ventana_Pago(EmpleadoActual, Database, productos, valor);//este valor es el precio final de todos los productos, no tiene ningun valor y hay que asignarlo

            // Mostrar el formulario
            ventanaPago.ShowDialog();

            // Cerrar este formulario
            this.Close();
        }

        private void txtbox_busqueda_producto_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_busqueda_producto_TextChanged(object sender, EventArgs e)
        {
            {
                // Obtener el texto ingresado en el txtbox de búsqueda
                string textoBusqueda = txtbox_busqueda_producto.Text.ToLower();

                // Obtener la lista de productos con la base de datos
                List<Producto> listaProductos = ProductosBaseDatos;

                // Filtrar y ordenar los productos según la similitud con el texto de búsqueda
                var coincidencias = listaProductos
                    .Where(p => p.NombreItem.ToLower().Contains(textoBusqueda) || p.IdProducto.ToLower().Contains(textoBusqueda))
                    .OrderByDescending(p => ObtenerSimilitud(p.NombreItem.ToLower(), textoBusqueda))
                    .ThenByDescending(p => ObtenerSimilitud(p.IdProducto.ToLower(), textoBusqueda))
                    .ToList();

                // Limpiar la lista de coincidencias
                lista_Coincidencias.Items.Clear();

                // Agregar las coincidencias a la lista
                foreach (var producto in coincidencias)
                {
                    // Crear un elemento para la lista
                    ListViewItem item = new ListViewItem($"ID: {producto.IdProducto} | Nombre: {producto.NombreItem}");

                    // Si hay una coincidencia exacta, marcar en verde
                    if (producto.NombreItem.ToLower() == textoBusqueda || producto.IdProducto.ToLower() == textoBusqueda)
                    {
                        item.ForeColor = Color.Green;
                    }

                    // Agregar el elemento a la lista
                    lista_Coincidencias.Items.Add(item);
                }
            }
        }

        private int ObtenerSimilitud(string texto1, string texto2)
        {
            int coincidencias = 0;
            int longitud = Math.Min(texto1.Length, texto2.Length);

            for (int i = 0; i < longitud; i++)
            {
                if (texto1[i] == texto2[i])
                {
                    coincidencias++;
                }
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
            // Verificar si se presionó la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener el texto ingresado en el cuadro de búsqueda
                string textoBusqueda = txtbox_busqueda_producto.Text.ToLower();
                bool encontrado = false;
                // Recorrer los elementos de lista_Coincidencias para verificar coincidencias exactas
                foreach (ListViewItem item in lista_Coincidencias.Items)
                {
                    // Extraer el texto del elemento (formato: "Nombre (ID)")
                    string textoElemento = item.Text.ToLower();

                    // Separar el nombre y el ID del elemento
                    int indiceParentesis = textoElemento.LastIndexOf(" (");
                    if (indiceParentesis != -1)
                    {
                        string nombre = textoElemento.Substring(0, indiceParentesis).Trim();
                        string id = textoElemento.Substring(indiceParentesis + 2, textoElemento.Length - indiceParentesis - 3).Trim();

                        // Verificar si el texto ingresado coincide exactamente con el nombre o el ID
                        if (textoBusqueda == nombre || textoBusqueda == id)
                        {
                            encontrado = true;
                            // Si hay coincidencia exacta, ejecutar la lógica deseada
                            //Producto producto = LLenar producto con la base de datos en base a textoBusqueda.
                            //AgregarProductoATabla(producto)

                            int stock = 0;//ObtenerStockProducto(fila.Cells["column_codigo"].Value?.ToString());
                            MessageBox.Show($"Producto encontrado: {item.Text}", $"cantidad disponible en stock: {stock}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    }

                }
                if (!encontrado)
                {
                    // Si no se encuentra coincidencia exacta, mostrar un mensaje opcional
                    MessageBox.Show("No se encontró el producto buscado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
        private void AgregarProductoATabla(Producto producto)
        {
            // Verificar si el producto ya está en la tabla
            foreach (DataGridViewRow fila in tabla_Productos.Rows)
            {
                if (fila.Cells["column_codigo"].Value?.ToString() == producto.IdProducto)
                {
                    MessageBox.Show("El producto ya está en la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Agregar una nueva fila con los valores del producto
            tabla_Productos.Rows.Add(
                producto.IdProducto,  // Columna Código
                producto.NombreItem,  // Columna Producto
                1,                    // Columna Cantidad (por defecto 1)
                producto.Precio       // Columna Valor (Precio * Cantidad)
            );
        } //funcion que agreaga en base a la consulta, llamar en txtbox_busqueda_producto_KeyDown

        private void tabla_Productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda modificada pertenece a la columna "Cantidad"
            if (tabla_Productos.Columns["column_cantidad"] != null && e.ColumnIndex == tabla_Productos.Columns["column_cantidad"].Index && e.RowIndex >= 0)

                {
                    // Obtener la fila modificada
                    DataGridViewRow fila = tabla_Productos.Rows[e.RowIndex];

                // Validar y obtener el valor de la cantidad
                if (int.TryParse(fila.Cells["column_cantidad"].Value?.ToString(), out int cantidad))
                {
                    if (cantidad == 0)
                    {
                        // Eliminar la fila si la cantidad es 0
                        tabla_Productos.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("El producto ha sido eliminado de la tabla porque la cantidad es 0.", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Obtener el stock del producto con la base de datos
                    int stock = 0;//ObtenerStockProducto(fila.Cells["column_codigo"].Value?.ToString());

                    // Verificar si la cantidad excede el stock
                    if (cantidad > stock)
                    {
                        MessageBox.Show($"La cantidad no puede ser mayor al stock disponible ({stock}).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fila.Cells["column_cantidad"].Value = stock; // Restablecer la cantidad al stock máximo
                        cantidad = stock; // Actualizar la cantidad para el cálculo del total
                        if (stock == 0)
                        {
                            // Eliminar la fila si la cantidad es 0
                            tabla_Productos.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("El producto ha sido eliminado de la tabla porque no hay stock de este producto.", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Obtener el precio del producto
                    decimal precio = Convert.ToDecimal(fila.Cells["column_valor"].Value) / (cantidad == 0 ? 1 : cantidad);

                    // Calcular el nuevo total
                    fila.Cells["column_valor"].Value = precio * cantidad;
                    valor = Convert.ToInt32(fila.Cells["column_valor"].Value);
                }
                else
                {
                    // Si el valor no es válido, restablecer la cantidad a 1
                    MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fila.Cells["column_cantidad"].Value = 1;

                    // Recalcular el total
                    decimal precio = Convert.ToDecimal(fila.Cells["column_valor"].Value);
                    fila.Cells["column_valor"].Value = precio;
                }
            }
        }
    }
}

