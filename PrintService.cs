
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace InkPos
{
    public partial class PrintService
    {
        public static void GenPDF(Factura factura, Cliente cliente, Empleado empleado)
        {
            string workDirPath = Path.Combine(AppContext.BaseDirectory, "texlive", "2025", "bin", "windows");
            string pdflatexPath = Path.Combine(
                workDirPath, "pdflatex.exe");
            
            string templatePath = Path.Combine(
                workDirPath, "TemplateFactura.tex");

            string tempDirPath = Path.Combine(
                AppContext.BaseDirectory, "Temp");

            if (!File.Exists(pdflatexPath))
                throw new FileNotFoundException("No se encontró pdflatex.exe", pdflatexPath);
            if (!File.Exists(templatePath))
                throw new FileNotFoundException("No se encontró TemplateFactura.tex", templatePath);

            // Leer plantilla original
            string contenido = File.ReadAllText(templatePath);
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

            Directory.CreateDirectory(tempDirPath);
            // Guardar .tex temporal con los datos reemplazados
            string customTex = Path.Combine(tempDirPath, $"R{factura.IdFactura}.tex");
            File.WriteAllText(customTex, reemplazado);
            string logoPath = Path.Combine(workDirPath, "Logo.png");
            File.Copy(logoPath, Path.Combine(tempDirPath, "Logo.png"));

            Process proc = new()
            {
                // Compilar con pdflatex.exe
                StartInfo = new ProcessStartInfo
                {
                    FileName = pdflatexPath,
                    Arguments = $"-output-directory={tempDirPath} {customTex}",
                    UseShellExecute = false,
                    CreateNoWindow = false
                }
            };

            proc.Start();
            
            if (proc.WaitForExit(1000))
            {
                proc.Kill();
            }
            // Mover PDF a destino final
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.Filter = "Documento Portable (*.pdf)|*.pdf";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = $"R{factura.IdFactura}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaSeleccionada = saveFileDialog.FileName;
                string pdfGenerado = Path.Combine(tempDirPath, $"R{factura.IdFactura}.pdf");
                File.Move(pdfGenerado, rutaSeleccionada, overwrite: true);
                File.Delete(customTex);
                File.Delete(logoPath);
                File.Delete(Path.Combine(tempDirPath, $"R{factura.IdFactura}.aux"));
                File.Delete(Path.Combine(tempDirPath, $"R{factura.IdFactura}.log"));
            }
        }

        [GeneratedRegex(@"\\C\{(.*?)\}")]
        private static partial Regex SearchRegex();
    }
}
