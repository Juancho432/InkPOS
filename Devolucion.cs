using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Devolucion(string IdFac, string IdProd, string fecha, string hora)
    {
        public string IdFactura { get; } = IdFac;
        public string IdProducto { get; } = IdProd;
        public string Fecha { get; set; } = fecha;
        public string Hora { get; set; } = hora;
    }
}