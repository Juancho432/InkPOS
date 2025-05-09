using Microsoft.Data.Sqlite;
using System.Text;
using System.Security.Cryptography;
using static InkPos.Excepciones;

namespace InkPos
{
    public class DataBaseHandler
    {
        private readonly string dbPath = "InkPos.db";
        private readonly string templatePath = "InkPosDBTemplate.sql";

        public DataBaseHandler()
        {
            if (File.Exists(dbPath))
            {
                if (!HasValidStructure())
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(dbPath);
                }
            }

            if (!File.Exists(dbPath))
            {
                CreateDatabaseFromTemplate();
            }
        }

        private bool HasValidStructure()
        {
            using (var checkConn = new SqliteConnection($"Data Source={dbPath}"))
            {
                checkConn.Open();

                // Verificamos que existan todas las tablas requeridas
                string[] tablasRequeridas = ["CLIENTE", "EMPLEADO", "PRODUCTO", "FACTURA", "DETALLE", "DEVOLUCION"];

                foreach (string tabla in tablasRequeridas)
                {
                    using var cmd = checkConn.CreateCommand();
                    cmd.CommandText = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tabla}';";

                    using var reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        SqliteConnection.ClearAllPools();
                        checkConn.Close();
                        checkConn.Dispose();
                        return false; // Faltó una tabla, la estructura no es válida
                    }
                }

                SqliteConnection.ClearAllPools();
                checkConn.Close();
                checkConn.Dispose();
                return true;
            }
        }

        private void CreateDatabaseFromTemplate()
        {
            if (!File.Exists(templatePath))
                throw new FileNotFoundException($"No se encontró el archivo de plantilla: {templatePath}");

            string sqlScript = File.ReadAllText(templatePath);

            using var tmpConn = new SqliteConnection($"Data Source={dbPath}");
            tmpConn.Open();

            using var cmd = tmpConn.CreateCommand();
            cmd.CommandText = sqlScript;
            cmd.ExecuteNonQuery();
        }
    
        public Empleado LoginEmpleado(string usuario, string contrasena)
        {
            SqliteConnection conn = new();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Empleado, Nombre, Telefono, Contrasena, Es_Admin, Salario 
                FROM EMPLEADO 
                WHERE Usuario = $usuario";
            cmd.Parameters.AddWithValue("$usuario", usuario);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                throw new EmpleadoInexistente();
            }

            string id = reader.GetString(0);
            string nombre = reader.GetString(1);
            string telefono = reader.GetString(2);
            string hashAlmacenado = reader.GetString(3);
            bool esAdmin = reader.GetInt32(4) != 0;
            double salario = reader.GetDouble(5);

            string hashIngresado = ToSHA256(contrasena);

            if (!hashIngresado.Equals(hashAlmacenado, StringComparison.OrdinalIgnoreCase))
            {
                throw new ContraseñaEmpleadoIncorrecta();
            }

            return new Empleado(id, nombre, telefono, esAdmin, salario);
        }

        private static string ToSHA256(string input)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
