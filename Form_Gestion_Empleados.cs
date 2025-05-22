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
    public partial class Form_Gestion_Empleados : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Gestion_Empleados(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
            dgv_Empleados.AutoGenerateColumns = false;
            AgregarColumnasAcciones();
        }

        private void AgregarColumnasAcciones()
        {
            // Evita duplicar columnas si el método se llama más de una vez
            if (!dgv_Empleados.Columns.Contains("Editar"))
            {
                // Columna Editar
                DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
                colEditar.Name = "Editar";
                colEditar.HeaderText = "✏️";
                colEditar.Image = Properties.Resources.pen_square; // Ruta relativa
                colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Empleados.Columns.Add(colEditar);
            }

            if (!dgv_Empleados.Columns.Contains("Eliminar"))
            {
                // Columna Eliminar
                DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
                colEliminar.Name = "Eliminar";
                colEliminar.HeaderText = "🗑️";
                colEliminar.Image = Properties.Resources.icon_borrar;
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Empleados.Columns.Add(colEliminar);
            }
        }
    }
}
