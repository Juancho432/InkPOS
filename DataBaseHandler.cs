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
            using var checkConn = new SqliteConnection($"Data Source={dbPath}");
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
                    INSERT INTO PRODUCTO (ID_Producto, Nombre, Precio, Stock)
                    VALUES ($id, $nombre, $precio, $stock);";

                cmd.Parameters.AddWithValue("$id", producto.Codigo);
                cmd.Parameters.AddWithValue("$nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("$precio", producto.Precio);
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

        public Producto ReadProductByID(string id, bool justValid = true)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $@"
                SELECT ID_Producto, Nombre, Precio, Stock
                FROM PRODUCTO
                WHERE ID_Producto = $codigo {(justValid ? "AND Stock > -1" : "")};"; // Los productos con stock -1 estan "Borrados"
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
                cmd.CommandText = @"
                        SELECT ID_Producto, Nombre, Precio, Stock 
                        FROM PRODUCTO
                        WHERE Stock > -1;";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new
                    (
                        idProd: reader.GetString(0),
                        nameItem: reader.GetString(1),
                        precio: reader.GetDecimal(2),
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

        public bool UpdateProduct(Producto producto)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE PRODUCTO
                    SET Nombre = $nombre,
                        Precio = $precio,
                        Stock = $stock
                    WHERE ID_Producto = $id;";
                cmd.Parameters.AddWithValue("$id", producto.Codigo);
                cmd.Parameters.AddWithValue("$nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("$precio", producto.Precio);
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

        public bool DeleteProduct(Producto producto)
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
                cmd.Parameters.AddWithValue("$id", producto.Codigo);

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
                cmd.Parameters.AddWithValue("$fecha", datetimeActual.Date.ToString("yyyy-MM-dd"));
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
                FROM DEVOLUCION
                WHERE ID_Factura = $id";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new DevolucionInexistente();
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
                FROM DEVOLUCION
                WHERE ID_Producto = $id";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new DevolucionInexistente();
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
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return devoluciones;
        }

        public List<Devolucion> ReadRefundsByDate(DateTime startDatetime, DateTime endDT)
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
                cmd.Parameters.AddWithValue("$start", startDatetime.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("$end", endDT.ToString("yyyy-MM-dd HH:mm:ss"));

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
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return devoluciones;
        }
    
        //      #### CRUD Detalle

        public bool CreateDetail(DetalleVenta detalle, long id_fac)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO DETALLE
                        (ID_Factura, ID_Producto, Cantidad, Valor)
                    VALUES 
                        ($id_fac, $id_prod, $cant, $val);";

                cmd.Parameters.AddWithValue("$id_fac", id_fac);
                cmd.Parameters.AddWithValue("$id_prod", detalle.Producto.Codigo);
                cmd.Parameters.AddWithValue("$cant", detalle.Cantidad);
                cmd.Parameters.AddWithValue("$val", detalle.Subtotal);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch
            {
                throw new DetalleExistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }

        public List<DetalleVenta> ReadDetailsByInvoice(int id)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            List<DetalleVenta> detalles = [];

            try
            {
                using SqliteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT ID_Producto, Cantidad
                    FROM DETALLE
                    WHERE ID_Factura = $id";
                cmd.Parameters.AddWithValue("$id", id);
    
                using var reader = cmd.ExecuteReader();
    
                while(reader.Read())
                {
                    DetalleVenta detalle = new
                    (
                        producto: ReadProductByID(id: reader.GetString(0), justValid: false),
                        cantidad: reader.GetInt32(1)
                    );

                    detalles.Add(detalle);
                }
            }
            catch 
            {
                throw new FacturaInexistente();
            }
            finally
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
            }

            return detalles;
        }

        //      #### CRUD Factura

        public long CreateInvoice(Factura factura)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            int filasAfectadas = 0;
            conn.Open();
            
            try
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                    INSERT INTO FACTURA 
                        (ID_Factura, ID_Cliente, ID_Empleado, Fecha, Hora, ID_Transaccion, Total)
                    VALUES 
                        (NULL, $id_cli, $id_emp, $fecha, $hora, $trans, $total);";
                    cmd.Parameters.AddWithValue("$id_cli", factura.IdCliente);
                    cmd.Parameters.AddWithValue("$id_emp", factura.IdEmpleado);
                    cmd.Parameters.AddWithValue("$fecha", factura.Fecha);
                    cmd.Parameters.AddWithValue("$hora", factura.Hora);
                    cmd.Parameters.AddWithValue("$trans", factura.IdTransaccion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("$total", factura.Total);

                    filasAfectadas = cmd.ExecuteNonQuery();
                };

                long id_factura;
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT last_insert_rowid();";
                    id_factura = (long)cmd.ExecuteScalar()!;
                }

                foreach (DetalleVenta item in factura.Detalles)
                {
                    CreateDetail(item, id_factura);
                }
                return id_factura;
            }
            catch
            {
                throw new FacturaExistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }   
        }
    
        public Factura ReadInvoiceByID(string id)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Factura, ID_Cliente, ID_Empleado, Fecha, Hora, ID_Transaccion, Total
                FROM FACTURA
                WHERE ID_Factura = $id";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new FacturaInexistente();
            }

            int ID_Factura = reader.GetInt32(0);
            string ID_Cliente = reader.GetString(1);
            string ID_Empleado = reader.GetString(2);
            string Fecha = reader.GetString(3);
            string Hora = reader.GetString(4);
            string? ID_Transaccion = reader.IsDBNull(5) ? null : reader.GetString(5);
            decimal Total = reader.GetDecimal(6);
            List<DetalleVenta> Detalles = ReadDetailsByInvoice(ID_Factura);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Factura(ID_Factura, ID_Cliente, ID_Empleado, Fecha, Hora, ID_Transaccion, Total, Detalles);
        }
    
        public List<Factura> ReadInvoiceByDates(DateTime startDT, DateTime endDT)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            List<Factura> facturas = [];

            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT ID_Factura, ID_Cliente, ID_Empleado, Fecha, Hora, ID_Transaccion, Total
                    FROM FACTURA
                    WHERE datetime(Fecha || ' ' || Hora) BETWEEN datetime($start) AND datetime($end)";
                cmd.Parameters.AddWithValue("$start", startDT.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("$end", endDT.ToString("yyyy-MM-dd HH:mm:ss"));

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Factura factura = new
                    (
                        idFac: reader.GetInt32(0),
                        idCl: reader.GetString(1),
                        idEmp: reader.GetString(2),
                        fecha: reader.GetString(3),
                        hora: reader.GetString(4),
                        trans: reader.GetString(5),
                        total: reader.GetDecimal(6),
                        detalles: ReadDetailsByInvoice(reader.GetInt32(0))
                    );
                    facturas.Add(factura);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return facturas;
        }

        public List<Factura> ReadAllInvoices()
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            List<Factura> facturas = [];

            try
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT ID_Factura, ID_Cliente, ID_Empleado, Fecha, Hora, ID_Transaccion, Total
                    FROM Factura;";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Factura factura = new
                    (
                        idFac: reader.GetInt32(0),
                        idCl: reader.GetString(1),
                        idEmp: reader.GetString(2),
                        fecha: reader.GetString(3),
                        hora: reader.GetString(4),
                        trans: reader.IsDBNull(5) ? null : reader.GetString(5),
                        total: reader.GetInt32(6),
                        detalles: ReadDetailsByInvoice(reader.GetInt32(0))
                    );
                    facturas.Add(factura);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }

            return facturas;
        }

        //      #### CRUD Cliente

        public bool CreateClient(Cliente cliente)
        {
            using SqliteConnection conn = new($"Data Source={dbPath}");
            int filasAfectadas = 0;
            conn.Open();

            try
            {
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                    INSERT INTO CLIENTE
                        (ID_Cliente, Nombre, Direccion, Telefono)
                    VALUES 
                        ($id_cli, $nombre, $dir, $tel);";
                    cmd.Parameters.AddWithValue("$id_cli", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("$nombre", cliente.NombreCliente);
                    cmd.Parameters.AddWithValue("$dir", cliente.Direccion);
                    cmd.Parameters.AddWithValue("$tel", cliente.Telefono);


                    filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                ;
            }
            catch
            {
                throw new ClienteExistente();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqliteConnection.ClearAllPools();
            }
        }
    
        public Cliente ReadClientByID(string id)
        {
            SqliteConnection conn = new($"Data Source={dbPath}");
            conn.Open();
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT ID_Cliente, Nombre, Direccion, Telefono
                FROM CLIENTE
                WHERE ID_Cliente = $id";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                SqliteConnection.ClearAllPools();
                conn.Close();
                conn.Dispose();
                throw new ClienteInexistente();
            }

            string ID = reader.GetString(0);
            string nombre = reader.GetString(1);
            string dir = reader.GetString(2);
            string tel = reader.GetString(3);

            SqliteConnection.ClearAllPools();
            conn.Close();
            conn.Dispose();
            return new Cliente(ID, nombre, dir, tel);
        }
    }
}
