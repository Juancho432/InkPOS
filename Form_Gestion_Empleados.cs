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
    public partial class Form_Gestion_Empleados : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        private List<Empleado> empleados;

        public Form_Gestion_Empleados(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
            txtbox_buscar_empleado.TextChanged += txtbox_buscar_empleado_TextChanged;
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

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Gestion_Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarDatosFiltrados(string filtro)
        {
            filtro = filtro.ToLower();
            var coincidencias = empleados.Where(p =>
                p.Nombre.Contains(filtro, StringComparison.CurrentCultureIgnoreCase) ||
                p.Id_Empleado.Contains(filtro, StringComparison.CurrentCultureIgnoreCase)).ToList();

            empleadoBindingSource.Clear();
            foreach (var producto in coincidencias)
            {
                empleadoBindingSource.Add(producto);
            }
        }

        private void button_añadir_empleado_Click(object sender, EventArgs e)
        {
            Form_Agregar_Empleado agregar_Empleado = new(EmpleadoActual, Database);
            agregar_Empleado.Show();
            Hide();
            agregar_Empleado.FormClosed += (s, args) =>
            {
                this.Show();
                CargarEmpleados(); // ← actualiza la vista
            };
        }

        private void txtbox_buscar_empleado_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbox_buscar_empleado.Text;
            CargarDatosFiltrados(filtro);
        }

        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            Empleado empleadoSeleccionado = (Empleado)dgv_Empleados.Rows[e.RowIndex].DataBoundItem;
            string nombreColumna = dgv_Empleados.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "Editar")
            {
                Empleado filaSeleccionada = (Empleado)empleadoBindingSource.List[e.RowIndex]!;
                Form_Modificar_Empleado modificar_Empleado = new(filaSeleccionada, Database);
                modificar_Empleado.Show();
                Hide();
                modificar_Empleado.FormClosed += (s, args) =>
                {
                    this.Show();
                    CargarEmpleados(); // ← actualiza la vista
                    
                };
            }
            else if (nombreColumna == "Eliminar")
            {
                var confirm = MessageBox.Show("¿Seguro que deseas eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        bool eliminado = Database.DeleteEmployed((empleadoSeleccionado));
                        if (eliminado)
                        {
                            MessageBox.Show("Empleado eliminado correctamente.");
                            CargarEmpleados();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el empleado.");
                        }
                    }
                    catch (EmpleadoInexistente)
                    {
                        MessageBox.Show("El empleado no existe o ya fue eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el empleado:\n" + ex.Message);
                    }
                }
                dgv_Empleados.ClearSelection();
            }
        }

        private void CargarEmpleados()
        {
            empleados = Database.ReadAllEmployees(); // ← recarga desde la base de datos
            empleadoBindingSource.Clear();
            foreach (var empleado in empleados)
            {
                empleadoBindingSource.Add(empleado);
            }

            dgv_Empleados.ClearSelection();
        }

        private void Form_Gestion_Empleados_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null; // Desactivar cursor del txtbox
        }

        private void dgv_Empleados_Leave(object sender, EventArgs e)
        {
            dgv_Empleados.ClearSelection();
        }
    }
}
