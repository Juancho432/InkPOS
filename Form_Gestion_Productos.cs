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
    public partial class Form_Gestion_Productos : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Gestion_Productos(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
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
                colEditar.Image = Image.FromFile("Images/editar.png"); // Ruta relativa
                colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Productos.Columns.Add(colEditar);
            }

            if (!dgv_Productos.Columns.Contains("Eliminar"))
            {
                // Columna Eliminar
                DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
                colEliminar.Name = "Eliminar";
                colEliminar.HeaderText = "🗑️";
                colEliminar.Image = Image.FromFile("Images/borrar.png");
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Productos.Columns.Add(colEliminar);
            }
        }
    }
}
