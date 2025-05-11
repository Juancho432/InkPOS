using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Producto(string IdProd, string NameItem,decimal Precio, int stock)
    {
        public string IdProducto { get; set; } = IdProd;
        public string NombreItem { get; set; } = NameItem;
        public decimal Precio { get; set; } = Precio;
        public int Stock { get; set; } = stock;
     

    }
}