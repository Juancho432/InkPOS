using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Factura(string IdFac, string IdCl, string idEmp, int fecha, int hora, string idTrans, decimal Total)
    {
        public string IdFactura { get; } = IdFac;
        public string IdCliente { get; } = IdCl;
        public string IdEmpleado { get; } = idEmp;
        public int fecha { get; set; } = fecha;
        public int hora { get; set; } = hora;
        public string IdTransaccion { get; } = idTrans;
        public decimal Total { get; set; } = Total;

    }

}