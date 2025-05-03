using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Pago
    {
        public decimal TotalVenta { get; set; }
        public decimal CantidadIngresada { get; set; }
        public string MetodoPago { get; set; }
        public string CodigoTransferencia { get; set; }


        public decimal CalcularResto()
        {
            if (MetodoPago == "Efectivo")
            {
                return CantidadIngresada - TotalVenta;
            }
            return 0;
        }

        public bool ValidarPago()
        {
            if (MetodoPago == "Efectivo")
            {
                return CantidadIngresada >= TotalVenta;
            }
            else if (MetodoPago == "Transferencia")
            {
                return !string.IsNullOrEmpty(CodigoTransferencia);
            }
            return false;
        }


        public bool CamposCompletos()
        {
            if (string.IsNullOrEmpty(MetodoPago))
                return false;

            if (MetodoPago == "Efectivo")
                return CantidadIngresada > 0;

            if (MetodoPago == "Transferencia")
                return !string.IsNullOrEmpty(CodigoTransferencia);

            return false;
        }
    }

}
