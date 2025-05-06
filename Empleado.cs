using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;  // Asegúrate de tener esta referencia

namespace InkPos
{
    public class Empleado
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        

        
    }
}
