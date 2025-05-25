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
        private List<Producto> productos;
        private List<Factura> facturas;
        public Form_Reporte_Venta(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();

            productos = Database.ReadAllProducts();
            facturas = Database.ReadAllInvoices();

            // Configurar componentes
            timepicker_fecha_inicio.Value = DateTime.Today;
            timepicker_fecha_fin.Value = DateTime.Today;

            dgv_ReporteVenta.AutoGenerateColumns = false;
            AgregarColumnasReporte();

            // Evitar selección de filas o celdas
            dgv_ReporteVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ReporteVenta.MultiSelect = false;
            dgv_ReporteVenta.ReadOnly = true;
            dgv_ReporteVenta.SelectionChanged += (s, e) => dgv_ReporteVenta.ClearSelection();

            // Eventos
            txtbox_buscar_producto.TextChanged += (s, e) => CargarReporteVentas();
            timepicker_fecha_inicio.ValueChanged += (s, e) => CargarReporteVentas();
            timepicker_fecha_fin.ValueChanged += (s, e) => CargarReporteVentas();

            CargarReporteVentas(); // Carga inicial

        }

        private void panel_reporte_ventas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Reporte_Venta_Load(object sender, EventArgs e)
        {
            facturas = Database.ReadAllInvoices();
            dgv_ReporteVenta.ClearSelection();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarColumnasReporte()
        {
            dgv_ReporteVenta.Columns.Clear();

            dgv_ReporteVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Codigo",
                ReadOnly = true
            });

            dgv_ReporteVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                ReadOnly = true
            });

            dgv_ReporteVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                ReadOnly = true
            });

            dgv_ReporteVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadVendida",
                HeaderText = "Cantidad Vendida",
                DataPropertyName = "CantidadVendida",
                ReadOnly = true
            });

            dgv_ReporteVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalGanado",
                HeaderText = "Total Ganado",
                DataPropertyName = "TotalGanado",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void CargarReporteVentas()
        {
            string filtroTexto = txtbox_buscar_producto.Text.Trim().ToLower();
            DateTime fechaInicio = timepicker_fecha_inicio.Value.Date;
            DateTime fechaFin = timepicker_fecha_fin.Value.Date.AddDays(1).AddSeconds(-1); // Fin del día

            // Diccionario para acumular ventas por producto
            var resumenVentas = new Dictionary<string, (int Cantidad, decimal Total)>();

            foreach (var factura in facturas)
            {
                if (!DateTime.TryParse(factura.Fecha, out DateTime fechaFactura))
                    continue;

                if (fechaFactura < fechaInicio || fechaFactura > fechaFin)
                    continue;

                foreach (var detalle in factura.Detalles)
                {
                    var idProducto = detalle.Producto.Codigo;

                    if (!resumenVentas.ContainsKey(idProducto))
                        resumenVentas[idProducto] = (0, 0m);

                    var actual = resumenVentas[idProducto];
                    resumenVentas[idProducto] = (
                        actual.Cantidad + detalle.Cantidad,
                        actual.Total + detalle.Cantidad * detalle.Producto.Precio
                    );
                }

            }

            // Generar lista final con cruce de productos
            var listaReporte = new List<dynamic>();

            foreach (var prod in productos)
            {
                bool coincide = string.IsNullOrEmpty(filtroTexto) ||
                                prod.Codigo.ToLower().Contains(filtroTexto) ||
                                prod.Nombre.ToLower().Contains(filtroTexto);

                if (!coincide)
                    continue;

                resumenVentas.TryGetValue(prod.Codigo, out var resumen);

                if (resumen.Cantidad > 0)
                {
                    listaReporte.Add(new
                    {
                        prod.Codigo,
                        prod.Nombre,
                        prod.Stock,
                        CantidadVendida = resumen.Cantidad,
                        TotalGanado = resumen.Total
                    });
                }
            }

            dgv_ReporteVenta.DataSource = null;
            dgv_ReporteVenta.DataSource = listaReporte;
            dgv_ReporteVenta.ClearSelection();
        }

        private void panel_reporte_ventas_Click(object sender, EventArgs e)
        {
            dgv_ReporteVenta.ClearSelection();
        }
    }
}
