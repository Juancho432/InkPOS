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
    public partial class Form_Ventana_Pago : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        private int Valor;
        private List<Producto> Productos;


        public Form_Ventana_Pago(Empleado empleado, DataBaseHandler database, List<Producto> productos, int valor )
        {
            EmpleadoActual = empleado;
            Database = database;
            Productos = productos ?? new List<Producto>();
            Valor = valor;
            InitializeComponent();
           
        }
    }
}
