using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class Producto(int IdProd, string NameItem, int stock, decimal pvp, decimal iva)
    {
        public int IdProducto { get; set; } = IdProd;
        public string NombreItem { get; set; } = NameItem;
        public int Stock { get; set; } = stock;
        public decimal Pvp { get; set; } = pvp;
        public decimal Iva { get; set; } = iva;


    }
}