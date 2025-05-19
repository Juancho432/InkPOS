public class Producto
{
    public string IdProducto { get; set; }
    public string NombreItem { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public Producto(string IdProd, string NameItem, decimal Precio, int stock)
    {
        IdProducto = IdProd;
        NombreItem = NameItem;
        this.Precio = Precio;
        this.Stock = stock;
    }

    public override string ToString()
    {
        return $"ID: {IdProducto} | Nombre: {NombreItem}";
    }
}
