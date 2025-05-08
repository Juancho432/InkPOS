using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Factura
    {
        public string IdFactura { get; set; }
        public List<Detalle> Items { get; set; }
        public decimal Total { get; set; }
        public decimal ValorRecibido { get; set; }
        public decimal Cambio { get; set; }
        public string MetodoPago { get; set; }
    }

}
