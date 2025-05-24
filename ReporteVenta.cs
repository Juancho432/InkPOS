using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class ReporteVenta (string codigo, string nombre, int stock, decimal TotalGanado, int cantidad_vendida)
    {
        public string Codigo { get; set; } = codigo;
        public string Nombre { get; set; } = nombre;
        public int Stock { get; set; } = stock;

        public decimal TotalGanado { get; set; } = TotalGanado;

        public int Cantidad_vendida { get; set; } = cantidad_vendida;

    }
}
