using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FacturaManager
    {
        private List<Factura> facturas = new List<Factura>();

        public FacturaManager()
        {
            // Ejemplo inicial (puedes quitarlo y cargar desde tu base de datos)
            facturas.Add(new Factura
            {
                IdFactura = "F001",
                Items = new List<ItemFactura>
            {
                new ItemFactura { NombreProducto = "Lapicero", Cantidad = 2, Precio = 1.5m },
                new ItemFactura { NombreProducto = "Cuaderno", Cantidad = 1, Precio = 5m }
            },
                Total = 8m
            });
        }

        // Buscar factura por ID
        public Factura BuscarFactura(string idFactura)
        {
            return facturas.FirstOrDefault(f => f.IdFactura == idFactura);
        }

        // Generar duplicado (simulado, muestra texto)
        public string GenerarDuplicadoPDF(Factura factura)
        {
            if (factura == null)
                return "Factura no encontrada.";

            return $"Factura duplicado generado:\n" +
                   $"ID: {factura.IdFactura}\n" +
                   $"Total: {factura.Total}\n" +
                   $"Productos:\n" +
                   string.Join("\n", factura.Items.Select(i =>
                       $"{i.NombreProducto} x{i.Cantidad} - {i.Precio} c/u"));
        }
    }

}
