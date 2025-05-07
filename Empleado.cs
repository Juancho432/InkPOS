namespace InkPos
{
    public class Empleado(string id, string nombre, string telefono, bool es_admin, double salario)
    {

        public string Id_Empleado { get; } = id;
        public string Nombre { get; } = nombre;
        public string Telefono { get; } = telefono;
        public bool Es_Admin { get; } = es_admin;
        public double Salario { get; } = salario;

    }
}
