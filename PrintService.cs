
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace InkPos
{
    public partial class PrintService
    {
        public static void GenPDF(Factura factura, Cliente cliente, Empleado empleado)
        {
            string tinitexPath = Path.Combine(AppContext.BaseDirectory, "LaTeX", "tinitex.exe");
            string plantillaPath = Path.Combine(AppContext.BaseDirectory, "LaTeX", "TemplateFactura.tex");
            string salidaDir = Path.Combine(AppContext.BaseDirectory, "Facturas");
            string temporalDir = Path.Combine(Path.GetTempPath(), "FacturaTemp");

            if (!File.Exists(tinitexPath))
                throw new FileNotFoundException("No se encontró tinitex.exe", tinitexPath);
            if (!File.Exists(plantillaPath))
                throw new FileNotFoundException("No se encontró la plantilla", plantillaPath);

            Directory.CreateDirectory(salidaDir);
            Directory.CreateDirectory(temporalDir);

            // Leer plantilla original
            string contenido = File.ReadAllText(plantillaPath);
            string details = "";
            int items = 0;
            decimal total = 0;

            for (int i = 0; i < factura.Detalles.Count; i++)
            {
                DetalleVenta detalle = factura.Detalles[i];
                Producto producto = detalle.Producto;
                string temp = $"{i + 1} & {producto.Codigo} & {producto.Nombre.ToUpper()} " +
                                $"& {detalle.Cantidad} & {producto.Precio} & {detalle.Subtotal} \\\\ \n";
                details += temp;
                items += detalle.Cantidad;
                total += detalle.Subtotal;
            }

            Dictionary<string, string> campos = new()
            {
                {"invoice_id", factura.IdFactura.ToString()},
                {"date", $"{factura.Fecha} {factura.Hora}"},
                {"pay_form", factura.IdTransaccion == null ? "Efectivo" : "Transferencia"},
                {"trans_id", factura.IdTransaccion ?? ""},
                {"cust_id", cliente.IdCliente},
                {"cust_tel", cliente.Telefono},
                {"cust_name", cliente.NombreCliente},
                {"cust_add", cliente.Direccion},
                {"emp_name", empleado.Nombre},
                {"details", details},
                {"total_items", factura.Detalles.Count.ToString()},
                {"total_products", items.ToString()},
                {"total", total.ToString()}
            };

            // Reemplazar campos \C{nombre} por los valores del diccionario
            string reemplazado = SearchRegex().Replace(contenido, match =>
            {
                string clave = match.Groups[1].Value.Trim();
                return campos.TryGetValue(clave, out var valor) ? valor : match.Value;
            });

            // Guardar .tex temporal con los datos reemplazados
            string temporalTex = Path.Combine(AppContext.BaseDirectory, "LaTeX", $"{factura.IdFactura}.tex");
            File.WriteAllText(temporalTex, reemplazado);

            // Compilar con tinitex.exe
            var psi = new ProcessStartInfo
            {
                FileName = tinitexPath,
                Arguments = $"--quiet {temporalTex}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using var proc = Process.Start(psi);

            // Mover PDF a destino final
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.Filter = "Documento Portable (*.pdf)|*.pdf";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = factura.IdFactura + ".pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaSeleccionada = saveFileDialog.FileName;
                string pdfGenerado = Path.Combine(AppContext.BaseDirectory, "LaTeX", $"{factura.IdFactura}.pdf");
                File.Move(pdfGenerado, rutaSeleccionada, overwrite: true);
                File.Delete(temporalTex);
            }
        }

        [GeneratedRegex(@"\\C\{(.*?)\}")]
        private static partial Regex SearchRegex();
    }
}
