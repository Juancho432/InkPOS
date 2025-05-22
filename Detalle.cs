namespace InkPos
{
    public class DetalleVenta(Producto producto, int cantidad)
    {
        public Producto Producto { get; } = producto;
        public int Cantidad { get; set; } = cantidad;
        public decimal Subtotal => Producto.Precio * Cantidad;

        public string Codigo => Producto.Codigo;
        public string Nombre => Producto.Nombre;
    }
}