using System.Globalization;

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
        }

        private void Txtbox_buscar_factura_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbox_buscar_factura.Text.ToLower();
            List<Factura> coincidencias = [.. Facturas.Where(p =>
                                            p.IdFactura.ToString().Contains(filtro))];

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

            if (DateTime.Compare(Inicio, Busqueda) == -1 &&
                DateTime.Compare(Busqueda, Final) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
