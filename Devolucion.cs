using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Devolucion(string IdFac, string IdProd, int fecha, int hora)
    {
        public string IdFactura { get; } = IdFac;
        public string IdProducto { get; } = IdProd;
        public int Fecha { get; set; } = fecha;
        public int Hora { get; set; } = hora;
    }
}