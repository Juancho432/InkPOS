
namespace InkPos
{
    public class Factura
    {
        public long IdFactura { get; set; }
        public string IdCliente { get; set; }
        public string IdEmpleado { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string? IdTransaccion { get; set; }
        public decimal Total { get; set; }

        // Lista de detalles de venta asociados a esta factura
        public List<DetalleVenta> Detalles { get; } = [];

        // Creacion
        public Factura(string idCl, string idEmp, decimal total, List<DetalleVenta> detalles)
        {
            IdCliente = idCl;
            IdEmpleado = idEmp; 
            Total = total;
            Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Hora = DateTime.Now.ToString("HH:mm:ss");
            Detalles = detalles;
        }

        // Lectura
        public Factura(int idFac, string idCl, string idEmp, string fecha,
                        string hora, string? trans, decimal total, List<DetalleVenta> detalles)
        {
            IdFactura = idFac;
            IdCliente = idCl;
            IdEmpleado = idEmp;
            Fecha = fecha;
            Hora = hora;
            IdTransaccion = trans;
            Total = total;
            Detalles = detalles;
        }
    }
}