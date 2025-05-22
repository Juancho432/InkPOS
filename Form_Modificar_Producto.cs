namespace InkPos
{
    public partial class Form_Modificar_Producto : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Modificar_Producto(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            string codigoProducto = txtbox_producto_a_modificar.Text.Trim();
            string campoSeleccionado = CB_valor_a_modificar.SelectedItem?.ToString()!;
            string nuevoValorTexto = txtbox_nuevo_valor.Text.Trim();
            Producto productoModificado;

            //Validar campos vacios y existencia de producto
            try
            {
                if (string.IsNullOrWhiteSpace(txtbox_producto_a_modificar.Text) || CB_valor_a_modificar.SelectedItem == null
                    || string.IsNullOrWhiteSpace(txtbox_nuevo_valor.Text))
                {
                    throw new Excepciones.CamposVacios();
                }
                productoModificado = Database.ReadProductByID(codigoProducto);
            }
            catch
            {
                return;
            }
            

            try
            {
                switch (campoSeleccionado)
                {
                    case "Nombre":
                        productoModificado.Nombre = nuevoValorTexto;
                        break;

                    case "Precio":
                        if (!decimal.TryParse(nuevoValorTexto, out decimal precio))
                            throw new FormatException("El precio debe ser un número decimal válido.");
                        productoModificado.Precio = precio;
                        break;

                    case "Stock":
                        if (!int.TryParse(nuevoValorTexto, out int stock))
                            throw new FormatException("El stock debe ser un número entero válido.");
                        if(stock < 0)
                        {
                            throw new Excepciones.StockNegativo();
                        }
                        else
                        {
                            productoModificado.Stock = stock;
                        }
                            
                        break;

                    default:
                        MessageBox.Show("El campo seleccionado no es válido.");
                        return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch
            {
                return;
            }

            
            bool exito = Database.UpdateProduct(productoModificado);

            if (exito)
            {
                MessageBox.Show("Producto modificado exitosamente.");
               Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto.");
            }
        }


        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            txtbox_nuevo_valor.Clear();
            txtbox_producto_a_modificar.Clear();
        }
    }
}
