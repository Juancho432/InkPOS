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
                // Esta linea inserta valores de prueba en la DB, eliminar para persistencia
                CreateDatabaseData();
            }
        }

        //      #### Helpers

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

            using SqliteConnection tmpConn = new($"Data Source={dbPath}");
            tmpConn.Open();

            using var cmd = tmpConn.CreateCommand();
            cmd.CommandText = sqlScript;
            cmd.ExecuteNonQuery();

            SqliteConnection.ClearAllPools();
            tmpConn.Close();
            tmpConn.Dispose();
        }

        private void CreateDatabaseData()
        {
            string templatePath = "InkPosDBTestData.sql";
            if (!File.Exists(templatePath))
                throw new FileNotFoundException($"No se encontró el archivo de plantilla");

            string sqlScript = File.ReadAllText(templatePath);

            using var tmpConn = new SqliteConnection($"Data Source={dbPath}");
            tmpConn.Open();

            using var cmd = tmpConn.CreateCommand();
            cmd.CommandText = sqlScript;
            cmd.ExecuteNonQuery();

            SqliteConnection.ClearAllPools();
            tmpConn.Close();
            tmpConn.Dispose();
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

        //      #### CRUD Producto

        public bool CreateProduct(Producto producto)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO PRODUCTO (ID_Producto, Nombre, /*Precio,*/ Stock)
                    VALUES ($id, $nombre, /*$precio,*/ $stock);";

                cmd.Parameters.AddWithValue("$id", producto.IdProducto);
                cmd.Parameters.AddWithValue("$nombre", producto.NombreItem);
                /*cmd.Parameters.AddWithValue("$precio", producto.Precio);*/
                cmd.Parameters.AddWithValue("$stock", producto.Stock);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                // Si el ID de el producto ya existe
                throw new ProductoExistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public Producto ReadProductByID(string id)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Producto, Nombre, Precio, Stock
                FROM PRODUCTO
                WHERE ID_Producto = $codigo AND Stock > -1"; // Los productos con stock -1 estan "Borrados"
            cmd.Parameters.AddWithValue("$codigo", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new ProductoInexistente();
            }

            string ID_Producto = reader.GetString(0);
            string Nombre = reader.GetString(1);
            decimal Precio = reader.GetDecimal(2);
            int Stock = reader.GetInt32(3);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Producto(ID_Producto, Nombre, Precio, Stock);
        }

        public Producto ReadProductByName(string nombre)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Producto, Nombre, Precio, Stock
                FROM PRODUCTO
                WHERE Nombre = $nombre AND Stock > -1"; // Los productos con stock -1 estan "Borrados"
            cmd.Parameters.AddWithValue("$nombre", nombre);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new ProductoInexistente();
            }

            string ID_Producto = reader.GetString(0);
            string Nombre = reader.GetString(1);
            decimal Precio = reader.GetDecimal(2);
            int Stock = reader.GetInt32(3);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Producto(ID_Producto, Nombre, Precio, Stock);
        }

        public List<Producto> ReadAllProducts()
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            List<Producto> productos = [];

            try
            {
                conn.Open();
                using SqliteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_Producto, Nombre, Precio, Stock FROM PRODUCTO;";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new
                    (
                        IdProd: reader.GetString(0),
                        NameItem: reader.GetString(1),
                        Precio: reader.GetDecimal(2),
                        stock: reader.GetInt32(3)
                    );
                    productos.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return productos;
        }

        public bool UpdateProducto(Producto producto)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE PRODUCTO
                    SET Nombre = $nombre,
                        /*Precio = $precio,*/
                        Stock = $stock
                    WHERE ID_Producto = $id;";
                cmd.Parameters.AddWithValue("$id", producto.IdProducto);
                cmd.Parameters.AddWithValue("$nombre", producto.NombreItem);
                /*cmd.Parameters.AddWithValue("$precio", producto.Precio);*/
                cmd.Parameters.AddWithValue("$stock", producto.Stock);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                throw new ProductoInexistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public bool DeleteProducto(Producto producto)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE PRODUCTO
                    SET Stock = -1
                    WHERE ID_Producto = $id;";
                cmd.Parameters.AddWithValue("$id", producto.IdProducto);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                throw new ProductoInexistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        //      #### CRUD Empleado
        public bool CreateEmployed(Empleado empleado, string usuario, string contrasena)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            contrasena = ToSHA256(contrasena);
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO EMPLEADO 
                    (ID_Empleado, Nombre, Telefono, Usuario, Contrasena, Es_Admin, Salario, Es_Activo)
                    VALUES 
                    ($id, $nombre, $telefono, $usuario, $contrasena, $esAdmin, $salario, 1);";
                cmd.Parameters.AddWithValue("$id", empleado.Id_Empleado);
                cmd.Parameters.AddWithValue("$nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("$telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("$usuario", usuario);
                cmd.Parameters.AddWithValue("$contrasena", contrasena); // hasheada
                cmd.Parameters.AddWithValue("$esAdmin", empleado.Es_Admin ? 1 : 0);
                cmd.Parameters.AddWithValue("$salario", empleado.Salario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqliteException ex)
            {
                if (ex.SqliteErrorCode == 19) // constraint violation
                {
                    if (ex.Message.Contains("EMPLEADO.ID_Empleado"))
                        throw new EmpleadoExistente();
                    else if (ex.Message.Contains("EMPLEADO.Usuario"))
                        throw new UsuarioEmpleadoExistente();
                }
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public Empleado ReadEmployedByID(string id)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Empleado, Nombre, Telefono, Es_Admin, Salario
                FROM Empleado
                WHERE ID_Empleado = $id AND Es_Activo = 1";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new EmpleadoInexistente();
            }

            string ID_Empleado = reader.GetString(0);
            string Nombre = reader.GetString(1);
            string Telefono = reader.GetString(2);
            bool Es_Admin = reader.GetInt32(3) == 1;
            double Salario = reader.GetDouble(4);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Empleado(ID_Empleado, Nombre, Telefono, Es_Admin, Salario);
        }

        public Empleado ReadEmployedByUsername(string usuario)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Empleado, Nombre, Telefono, Es_Admin, Salario
                FROM Empleado
                WHERE Usuario = $usuario AND Es_Activo = 1";
            cmd.Parameters.AddWithValue("$usuario", usuario);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new EmpleadoInexistente();
            }

            string ID_Empleado = reader.GetString(0);
            string Nombre = reader.GetString(1);
            string Telefono = reader.GetString(2);
            bool Es_Admin = reader.GetInt32(3) == 1;
            double Salario = reader.GetDouble(4);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Empleado(ID_Empleado, Nombre, Telefono, Es_Admin, Salario);
        }

        public List<Empleado> ReadAllEmployees()
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            var empleados = new List<Empleado>();

            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT ID_Empleado, Nombre, Telefono, Es_Admin, Salario
                    FROM EMPLEADO
                    WHERE Es_Activo = 1;";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Empleado empleado = new
                    (
                        id: reader.GetString(0),
                        nombre: reader.GetString(1),
                        telefono: reader.GetString(2),
                        es_admin: reader.GetInt32(3) == 1,
                        salario: reader.GetDouble(4)
                    );
                    empleados.Add(empleado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar empleados:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return empleados;


        }

        public bool UpdateEmployedData(Empleado empleado)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE Empleado
                    SET Nombre = $nombre,
                        Telefono = $telefono,
                        Es_Admin = $admin,
                        Salario = $salario
                    WHERE ID_Empleado = $id;";
                cmd.Parameters.AddWithValue("$id", empleado.Id_Empleado);
                cmd.Parameters.AddWithValue("$nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("$telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("$admin", empleado.Es_Admin ? 1 : 0);
                cmd.Parameters.AddWithValue("$salario", empleado.Salario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                throw new EmpleadoInexistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public bool UpdateEmployedLogin(Empleado empleado, string usuario, string contrasena)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE Empleado
                    SET Usuario = $user,
                        Contraseña = $contra
                    WHERE ID_Empleado = $id;";
                cmd.Parameters.AddWithValue("$id", empleado.Id_Empleado);
                cmd.Parameters.AddWithValue("$user", usuario);
                cmd.Parameters.AddWithValue("$contra", ToSHA256(contrasena));

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqliteException ex)
            {
                if (ex.SqliteErrorCode == 19) // constraint violation
                {
                    if (ex.Message.Contains("EMPLEADO.ID_Empleado"))
                        throw new EmpleadoExistente();
                    else if (ex.Message.Contains("EMPLEADO.Usuario"))
                        throw new UsuarioEmpleadoExistente();
                }
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public bool DeleteEmployed(Empleado empleado)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE EMPLEADO
                    SET Es_Activo = 0
                    WHERE ID_Empleado = $id";
                cmd.Parameters.AddWithValue("$id", empleado.Id_Empleado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                throw new EmpleadoInexistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public Empleado LoginEmployed(string usuario, string contrasena)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Empleado, Nombre, Telefono, Contrasena, Es_Admin, Salario 
                FROM EMPLEADO 
                WHERE Usuario = $usuario AND Es_Activo = 1";
            cmd.Parameters.AddWithValue("$usuario", usuario);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
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
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new ContraseñaEmpleadoIncorrecta();
            }

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Empleado(id, nombre, telefono, esAdmin, salario);
        }

        //      #### CRUD Devolucion

        public bool CreateRefund(string id_fact, string id_prod)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO DEVOLUCION (ID_Factura, ID_Producto, Fecha, Hora)
                    VALUES ($id_fact, $id_prod, $fecha, $hora);";

                cmd.Parameters.AddWithValue("$id_fact", id_fact);
                cmd.Parameters.AddWithValue("$id_prod", id_prod);
                DateTime datetimeActual = DateTime.Now;
                cmd.Parameters.AddWithValue("$fecha", datetimeActual.Date.ToString("yyyy-MM-DD"));
                cmd.Parameters.AddWithValue("$hora", datetimeActual.Hour.ToString("HH:mm:ss"));

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                // Si la devolucion ya existe
                throw new DevolucionExistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public Devolucion ReadRefundByInvoice(string id)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Factura, ID_Producto, Fecha, Hora
                FROM Devolucion
                WHERE ID_Factura = $id";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new EmpleadoInexistente();
            }

            string ID_Factura = reader.GetString(0);
            string ID_Producto = reader.GetString(1);
            string Fecha = reader.GetString(2);
            string Hora = reader.GetString(3);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Devolucion(ID_Factura, ID_Producto, Fecha, Hora);
        }

        public Devolucion ReadRefundByProduct(string id)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Factura, ID_Producto, Fecha, Hora
                FROM Devolucion
                WHERE ID_Producto = $id";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new EmpleadoInexistente();
            }

            string ID_Factura = reader.GetString(0);
            string ID_Producto = reader.GetString(1);
            string Fecha = reader.GetString(2);
            string Hora = reader.GetString(3);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Devolucion(ID_Factura, ID_Producto, Fecha, Hora);
        }

        public List<Devolucion> ReadAllRefunds()
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            List<Devolucion> devoluciones = [];

            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT ID_Factura, ID_Produto, Fecha, Hora
                    FROM DEVOLUCION;";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Devolucion devolucion = new
                    (
                        IdFac: reader.GetString(0),
                        IdProd: reader.GetString(1),
                        fecha: reader.GetString(2),
                        hora: reader.GetString(3)
                    );
                    devoluciones.Add(devolucion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return devoluciones;
        }

        public List<Devolucion> ReadRefundsByDate(DateTime startDatetime, DateTime endDateTime)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            List<Devolucion> devoluciones = [];

            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT ID_Factura, ID_Produto, Fecha, Hora
                    FROM DEVOLUCION
                    WHERE datetime(Fecha || ' ' || Hora) BETWEEN datetime($start) AND datetime($end);";
                cmd.Parameters.AddWithValue("$start", startDatetime.ToString("yyyy-MM-DD HH:mm:ss"));
                cmd.Parameters.AddWithValue("$end", endDateTime.ToString("yyyy-MM-DD HH:mm:ss"));

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Devolucion devolucion = new
                    (
                        IdFac: reader.GetString(0),
                        IdProd: reader.GetString(1),
                        fecha: reader.GetString(2),
                        hora: reader.GetString(3)
                    );
                    devoluciones.Add(devolucion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return devoluciones;
        }
    
        //      #### CRUD Factura

        public bool CreateInvoice(Factura factura)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            int filasAfectadas = 0;
            conn.Open();
            
            try
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                    INSERT INTO DEVOLUCION (ID_Factura, ID_Producto, Fecha, Hora)
                    VALUES ($id_fact, $id_prod, $fecha, $hora);";

                    filasAfectadas = cmd.ExecuteNonQuery();
                };
            }
            catch (SqliteException ex)
            {
                
            }

            try
            {
                using SqliteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO DEVOLUCION (ID_Factura, ID_Producto, Fecha, Hora)
                    VALUES ($id_fact, $id_prod, $fecha, $hora);";

                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (SqliteException ex)
            {

            }

            conn.Close();
            conn.Dispose();
            SqliteConnection.ClearAllPools();
            return filasAfectadas > 0;
        }
    }
}
