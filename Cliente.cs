using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Cliente(string idCl, string NombreCl, string Direccion, string Tel)
    {
        public string IdCliente { get; set; } = idCl;
        public string NombreCliente { get; set; } = NombreCl;
        public string Direccion { get; set; } = Direccion;
        public string Telefono { get; set; } = Tel;

    }
}
