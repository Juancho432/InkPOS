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
    public partial class Form_Gestion_Facturas : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;

        public Form_Gestion_Facturas(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
            dgv_Facturas.AutoGenerateColumns = false;
            AgregarColumnasAcciones();
        }

        private void AgregarColumnasAcciones()
        {
            // Columna Ver
            if (!dgv_Facturas.Columns.Contains("Ver"))
            {
                DataGridViewImageColumn colVer = new DataGridViewImageColumn();
                colVer.Name = "Ver";
                colVer.HeaderText = "👁️"; // 
                colVer.Image = Properties.Resources.overview; 
                colVer.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Facturas.Columns.Add(colVer);
            }

            // Columna Imprimir
            if (!dgv_Facturas.Columns.Contains("Imprimir"))
            {
                DataGridViewImageColumn colImprimir = new DataGridViewImageColumn();
                colImprimir.Name = "Imprimir";
                colImprimir.HeaderText = "🖨️";
                colImprimir.Image = Properties.Resources.print;
                colImprimir.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Facturas.Columns.Add(colImprimir);
            }

            // Columna Editar
            if (!dgv_Facturas.Columns.Contains("Editar"))
            {
                DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
                colEditar.Name = "Editar";
                colEditar.HeaderText = "✏️";
                colEditar.Image = Properties.Resources.pen_square;
                colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv_Facturas.Columns.Add(colEditar);
            }
        }
    }
}
