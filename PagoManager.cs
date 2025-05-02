using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class PagoManager
    {
        public string FinalizarPago(Pago pago)
        {
            if (string.IsNullOrEmpty(pago.MetodoPago))
                return "Advertencia: Hay campos vacíos.";

            if (pago.MetodoPago == "Efectivo")
            {
                if (pago.CantidadIngresada < pago.TotalVenta)
                    return "Advertencia: Dinero ingresado menor al total de venta.";
                return "Pago registrado correctamente.";
            }

            if (pago.MetodoPago == "Transferencia")
            {
                if (string.IsNullOrEmpty(pago.CodigoTransferencia))
                    return "Advertencia: Código de transferencia inválido.";
                return "Pago registrado correctamente.";
            }

            return "Advertencia: Método de pago no reconocido.";
        }


    }

}
