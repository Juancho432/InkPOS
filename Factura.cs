using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Factura(string IdFac, string IdCl, string idEmp, string fecha, string hora, string idTrans, decimal Total)
    {
        public string IdFactura { get; set; } = IdFac;
        public string IdCliente { get; } = IdCl;
        public string IdEmpleado { get; } = idEmp;
        public string Fecha { get; set; } = fecha;
        public string Hora { get; set; } = hora;
        public string? IdTransaccion { get; } = idTrans;
        public decimal Total { get; set; } = Total;

        // Lista de detalles de venta asociados a esta factura
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}