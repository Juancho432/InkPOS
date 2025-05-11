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

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            string campoSeleccionado = CB_valor_a_modificar.SelectedItem?.ToString();
            string nuevoValorTexto = txtbox_nuevo_valor.Text.Trim();

            //Validar campos vacios
            try
            {
                if (CB_valor_a_modificar.SelectedItem == null || string.IsNullOrWhiteSpace(txtbox_nuevo_valor.Text))
                {
                    throw new Excepciones.CamposVacios();
                }
            }
            catch 
            {
                return;
            }


            // Preparar valor convertido según el campo seleccionado
            object nuevoValor = null;

            try
            {
                switch (campoSeleccionado)
                {
                    case "Nombre":
                        nuevoValor = nuevoValorTexto;
                        break;

                    case "Precio":
                        if (!decimal.TryParse(nuevoValorTexto, out decimal precio))
                            throw new FormatException("El precio debe ser un número decimal válido.");
                        nuevoValor = precio;
                        break;

                    case "Stock":
                        if (!int.TryParse(nuevoValorTexto, out int stock))
                            throw new FormatException("El stock debe ser un número entero válido.");
                        nuevoValor = stock;
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


            //// Llamar método en base de datos
            //bool exito = Database.ModificarProducto(codigoProducto, campoSeleccionado, nuevoValor);

            //if (exito)
            //{
            //    MessageBox.Show("Producto modificado exitosamente.");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo modificar el producto.");
            //}
        }
    }
}
