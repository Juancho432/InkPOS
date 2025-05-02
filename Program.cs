namespace InkPos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProductosDatos datos = new ProductosDatos();

            Console.WriteLine("¿Buscar por ID o por Nombre?");
            string criterio = Console.ReadLine();

            Console.WriteLine("Ingrese el valor a buscar:");
            string valor = Console.ReadLine();

            List<Productos> resultado = datos.BuscarProductos(criterio.ToUpper(), valor);

            Console.WriteLine("=== Resultados de la búsqueda ===");
            foreach (var prod in resultado)
            {
                Console.WriteLine($"ID: {prod.IdProducto} | Nombre: {prod.NombreItem} | Stock: {prod.Stock} | Precio: {prod.Pvp} | IVA: {prod.Iva}");
            }

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}