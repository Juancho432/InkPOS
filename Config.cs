
namespace InkPos
{
    internal class Config
    {
        public string? Nombre { get; set; }
        public string? Telefono { get; set; } 
        public string? Direccion { get; set;} 
    
        public Config()
        {

        }

        public Config(string nombre, string telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
