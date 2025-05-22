
namespace InkPos
{
    public class Producto(string idProd, string nameItem, decimal precio, int stock)
    {
        public string Codigo { get; set; } = idProd;
        public string Nombre { get; set; } = nameItem;
        public decimal Precio { get; set; } = precio;
        public int Stock { get; set; } = stock;
    } 
}
