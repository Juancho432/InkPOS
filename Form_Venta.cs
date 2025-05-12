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

        public Form_Venta(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void txtbox_busqueda_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            lista_Coincidencias.Items.Clear();
            string busqueda = txtbox_busqueda_producto.Text;


           


            List<string> Nombre_Producto = new List<string>();
            var resultados = new List<(string palabra, int coincidencias)>();


            //DDBB
            // se solicita agregar consulta SQL para mostrar los valores en la lista (Nombre_Producto)
            // y llenar la lista con los nombres de los productos

            int contador = 0;
            int contador2 = 0;
           


            foreach (string nombre in Nombre_Producto)
            {
                foreach (char c in busqueda)
                {
                    if (nombre.Contains(c))
                    {
                        contador++;
                        contador2++;
                    }
                }

                if (contador2 > 0) {
                    resultados.Add((nombre, contador2));
                }

            }

            try
            {
                if (contador == 0)
                {
                    throw new Excepciones.ProductoInexistente();
                }
            }
            catch
            {

                return;
            }

            var ordenados = resultados.OrderByDescending(r => r.coincidencias);
            
            foreach(var item in ordenados)
            {
                lista_Coincidencias.Items.Add(item.palabra);
            }
            
          
            
        }
    }
}
