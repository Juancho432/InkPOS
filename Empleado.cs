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

        private string connectionString = "Host=localhost;Username=postgres;Password=emg1234;Database=InkPosDB";

        public Empleado VerificarCredenciales(string usuario, string contrasena)
        {
            Empleado empleado = null;

            // Consulta SQL
            string query = "SELECT * FROM empleados WHERE usuario = @usuario AND contrasena = @contrasena";

            // Conexión con PostgreSQL usando Npgsql
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                // Usando NpgsqlCommand en lugar de SqlCommand
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                // Abre la conexión
                connection.Open();

                // Usar NpgsqlDataReader en lugar de SqlDataReader
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    empleado = new Empleado
                    {
                        IdEmpleado = reader["id_empleado"].ToString(),
                        Nombre = reader["nombre_empleado"].ToString(),
                        Telefono = reader["telefono_empleado"].ToString(),
                        Cargo = reader["cargo_empleado"].ToString(),
                        Salario = Convert.ToDecimal(reader["salario_empleado"]),
                        Usuario = reader["usuario"].ToString(),
                        Contrasena = reader["contrasena"].ToString()
                    };
                }

                reader.Close();
            }

            return empleado;
        }
    }
}
