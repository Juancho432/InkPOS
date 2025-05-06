using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace InkPos
{
    public class ConexionDB
    {
        private string cadenaConexion = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=InkPosDB";
        private static string connectionString = "Host=localhost; Port=5432; Username=postgres;Password=admin;Database=InkPosDB";
        public NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion);
            try
            {
                conexion.Open(); 
                Console.WriteLine("Conexión exitosa.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
            return conexion;
        }


        public static Empleado VerificarCredenciales(string usuario, string contrasena)
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

        public static bool ComprobarCodigoProducto(string codigo)
        {
            string query = "SELECT * FROM productos WHERE codigo = @codigo";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@codigo", codigo);

                    connection.Open();
                    var result = command.ExecuteScalar();

                    return result != null; // Devuelve true si existe, false si no
                }
            }
        }

        public static bool ModificarProductoEnDB(Producto producto)
        {
            string query = @"UPDATE productos 
                     SET nombre = @nombre, precio = @precio, cantidad = @cantidad 
                     WHERE codigo = @codigo";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@precio", producto.Precio);
                    command.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                    command.Parameters.AddWithValue("@codigo", producto.Codigo);

                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public static List<Producto> ObtenerProductosDesdeDB()
        {
            List<Producto> productos = new List<Producto>();

            string query = "SELECT codigo, nombre, precio, cantidad FROM productos";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            Codigo = reader["codigo"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Precio = Convert.ToDecimal(reader["precio"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"])
                        });
                    }
                }
            }

            return productos;
        }

        public static bool InsertarProductoEnDB(Producto producto)
        {
            string query = @"INSERT INTO productos (codigo, nombre, precio, cantidad)
                     VALUES (@codigo, @nombre, @precio, @cantidad)";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@codigo", producto.Codigo);
                    command.Parameters.AddWithValue("@nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@precio", producto.Precio);
                    command.Parameters.AddWithValue("@cantidad", producto.Cantidad);

                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }


    }
}
