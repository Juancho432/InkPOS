using System.Globalization;
using System.ComponentModel;

namespace InkPos
{
    public partial class Form_Gestion_Facturas : Form
    {
        private readonly Empleado EmpleadoActual;
        private readonly DataBaseHandler Database;
        private readonly List<Factura> Facturas;

        public Form_Gestion_Facturas(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            Facturas = Database.ReadAllInvoices();
            InitializeComponent();
        }

        private void Form_Gestion_Facturas_Load(object sender, EventArgs e)
        {
            foreach (Factura item in Facturas)
            {
                facturaBindingSource.Add(item);
            }
            TP_Fecha_Inicio.MinDate = TP_Fecha_Fin.MinDate =
                DateTime.ParseExact(
                    Database.ReadOldestInvoice(),
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture);

            TP_Fecha_Inicio.MaxDate = TP_Fecha_Fin.MaxDate = DateTime.Now;
        }

        private void Filtro(object sender, EventArgs e)
        {
            List<Factura> coincidencias =
                [.. Facturas.Where(p =>
                    p.IdFactura.ToString().Contains(txtbox_buscar_factura.Text) &&
                    VerificarFechas(
                        TP_Fecha_Inicio.Checked
                            ? TP_Fecha_Inicio.Value.ToString("yyyy-MM-dd")
                            : null,
                        TP_Fecha_Fin.Checked
                            ? TP_Fecha_Fin.Value.ToString("yyyy-MM-dd")
                            : null,
                        p.Fecha) &&
                     p.IdEmpleado.Contains(txtbox_buscar_factura_empleado.Text))];

            facturaBindingSource.List.Clear();
            foreach (Factura item in coincidencias)
            {
                facturaBindingSource.Add(item);
            }
        }

        private bool VerificarFechas(string? inicio, string? final, string busqueda)
        {
            string formato = "yyyy-MM-dd";
            DateTime Inicio;
            DateTime Final;
            DateTime Busqueda = DateTime.ParseExact(
                busqueda, formato, CultureInfo.InvariantCulture);

            if (inicio != null)
            {
                Inicio = DateTime.ParseExact(
                    inicio, formato, CultureInfo.InvariantCulture);
            }
            else
            {
                Inicio = DateTime.ParseExact(
                    Database.ReadOldestInvoice(), formato, CultureInfo.InvariantCulture);
            }

            if (final != null)
            {
                Final = DateTime.ParseExact(final, formato, CultureInfo.InvariantCulture);
            }
            else
            {
                Final = DateTime.ParseExact(
                    Database.ReadNewestInvoice(), formato, CultureInfo.InvariantCulture);
            }

            if (DateTime.Compare(Inicio, Busqueda) <= 0 &&
                DateTime.Compare(Busqueda, Final) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TP_Validating(object sender, CancelEventArgs e)
        {
            if (!TP_Fecha_Inicio.Checked)
            {
                TP_Fecha_Inicio.Value =
                    DateTime.ParseExact(
                        Database.ReadOldestInvoice(),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture);
                TP_Fecha_Inicio.Checked = false;
            }

            if (!TP_Fecha_Fin.Checked)
            {
                TP_Fecha_Fin.Value =
                    DateTime.ParseExact(
                        Database.ReadNewestInvoice(),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture);
                TP_Fecha_Fin.Checked = false;
            }

            // Si la fecha de inicio es superior a la de fin
            if (DateTime.Compare(TP_Fecha_Inicio.Value, TP_Fecha_Fin.Value) == 1)
            {
                e.Cancel = true;

                MessageBox.Show(
                    "Las fechas seleccionadas son invalidas, intente con otro rango",
                    "Rango Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                TP_Fecha_Inicio.Value =
                    DateTime.ParseExact(
                        Database.ReadOldestInvoice(),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture);

                TP_Fecha_Fin.Value =
                    DateTime.ParseExact(
                        Database.ReadNewestInvoice(),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture);
            }
        }

        private void DG_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Factura facturaActual = (Factura)facturaBindingSource.List[e.RowIndex]!;
            Empleado empleadoActual = Database.ReadEmployedByID(facturaActual.IdEmpleado);
            Cliente clienteActual = Database.ReadClientByID(facturaActual.IdCliente);
            // Ver
            if (e.ColumnIndex == 7)
            {
                Form_InformeFactura informe = new(
                    facturaActual,
                    EmpleadoActual,
                    clienteActual);

                informe.Show();
                Hide();
                informe.FormClosed += (s, e) => Show();
            }
            // Imprimir
            else if (e.ColumnIndex == 8)
            {
                PrintService.GenPDF(facturaActual, clienteActual, empleadoActual);
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
