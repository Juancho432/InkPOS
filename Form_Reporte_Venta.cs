using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InkPos
{
    public partial class Form_Reporte_Venta : Form
    {
        private Empleado EmpleadoActual;
        private DataBaseHandler Database;
        private List<Factura> facturas;
        public Form_Reporte_Venta(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();
        }

        private void panel_reporte_ventas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Reporte_Venta_Load(object sender, EventArgs e)
        {
            lbl_dual_fechadesde.Visible = false;
            lbl_dual_hasta.Visible = false;
            lbl_fecha_fin.Visible = false;
            lbl_fecha_inicio.Visible = false;
            timepicker_dual_FechaFin.Visible = false;
            timepicker_dual_FechaInicio.Visible = false;
            timepicker_fecha_fin.Visible = false;
            timepicker_fecha_inicio.Visible = false;
            txtbox_buscar_producto.Visible = false;
            TxtDual_buscar_producto.Visible = false;

            //facturas = Database.ReadAll();
            //MostrarProductos(productos);
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_dual_fechadesde.Visible = false;
            lbl_dual_hasta.Visible = false;
            lbl_fecha_fin.Visible = false;
            lbl_fecha_inicio.Visible = false;
            timepicker_dual_FechaFin.Visible = false;
            timepicker_dual_FechaInicio.Visible = false;
            timepicker_fecha_fin.Visible = false;
            timepicker_fecha_inicio.Visible = false;
            txtbox_buscar_producto.Visible = false;
            TxtDual_buscar_producto.Visible = false;

            switch (CB_filtro.SelectedItem.ToString())
            {
                case "Nombre/Código producto":
                    txtbox_buscar_producto.Visible = true;
                    break;

                case "Fecha":
                    timepicker_fecha_fin.Visible = true;
                    timepicker_fecha_inicio.Visible = true;
                    lbl_fecha_fin.Visible = true;
                    lbl_fecha_inicio.Visible = true;
                    break;

                case "Nombre/Código y Fecha":
                    TxtDual_buscar_producto.Visible = true;
                    lbl_dual_fechadesde.Visible = true;
                    lbl_dual_hasta.Visible = true;
                    timepicker_dual_FechaFin.Visible = true;
                    timepicker_dual_FechaInicio.Visible = true;
                    break;
            }

        }

        /*
        private void txtbox_buscar_producto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbox_buscar_producto.Text.ToLower();

            var coincidencias = productos.Where(p =>
                p.Nombre.Contains(filtro, StringComparison.CurrentCultureIgnoreCase) ||
                p.Codigo.Contains(filtro, StringComparison.CurrentCultureIgnoreCase)).ToList();

            MostrarProductos(coincidencias);
        }

        private void FiltrarPorFechas()
        {
            DateTime desde = timepicker_fecha_inicio.Value.Date;
            DateTime hasta = timepicker_fecha_fin.Value.Date;

            var resultados = productos.Where(p =>
                p.FechaVenta >= desde && p.FechaVenta <= hasta).ToList();

            MostrarProductos(resultados);
        }

        private void FiltrarTextoYFechas()
        {
            string filtro = TxtDual_buscar_producto.Text.ToLower();
            DateTime desde = timepicker_dual_FechaInicio.Value.Date;
            DateTime hasta = timepicker_dual_FechaFin.Value.Date;

            var resultados = productos.Where(p =>
                (p.Nombre.Contains(filtro, StringComparison.CurrentCultureIgnoreCase) ||
                 p.Codigo.Contains(filtro, StringComparison.CurrentCultureIgnoreCase)) &&
                p.FechaVenta >= desde && p.FechaVenta <= hasta).ToList();

            MostrarProductos(resultados);
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dgv_Facturas.DataSource = null;
            dgv_Facturas.DataSource = lista;
        }
        
        */

    }
}
