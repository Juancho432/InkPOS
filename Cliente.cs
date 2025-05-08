namespace InkPos
{
    public class Cliente
    {
        string ID_Cliente { get;  }
        string Nombre { get; }
        string Direccion { get; }
        string Telefono { get; }

        public Cliente(string id, string nombre, string direccion, string telefono)
        {
            ID_Cliente = id;
            Nombre = nombre;    
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
