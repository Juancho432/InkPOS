using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Producto(int IdProd, string NameItem, int stock)
    {
        public int IdProducto { get; set; } = IdProd;
        public string NombreItem { get; set; } = NameItem;
        public int Stock { get; set; } = stock;
     

    }
}