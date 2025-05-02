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
            if (!pago.CamposCompletos())
            {
                return "Advertencia: Hay campos vacíos.";
            }

            if (!pago.ValidarPago())
            {
                if (pago.MetodoPago == "Efectivo")
                    return "Advertencia: Dinero ingresado menor al total de venta.";
                else if (pago.MetodoPago == "Transferencia")
                    return "Advertencia: Código de transferencia inválido.";
            }

            // Aquí guardarías el pago en la base de datos o lista
            return "Pago registrado correctamente.";
        }
    }

}
