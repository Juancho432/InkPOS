using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string NombreItem { get; set; }
        public int Stock { get; set; }
        public decimal Pvp { get; set; }
        public decimal Iva { get; set; }

        public override string ToString()
        {
            return $"{NombreItem} - Stock: {Stock}";
        }

    }
}
