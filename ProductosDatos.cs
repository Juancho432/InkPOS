using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InkPos
{
    public class ProductosDatos
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin;Database=InkPosDB";

        public List<Productos> BuscarProductos(string valor)
        {
            List<Productos> productos = new List<Productos>();

            string query = @"
                SELECT p.id_producto, i.nombre_item, p.stock, i.pvp_item, i.porcentaje_iva_item
                FROM productos p
                JOIN items i ON p.id_item = i.id_item
                WHERE p.id_producto::text ILIKE @valor OR i.nombre_item ILIKE @valor";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Productos prod = new Productos
                            {
                                IdProducto = reader.GetInt32(0),
                                NombreItem = reader.GetString(1),
                                Stock = reader.GetInt32(2),
                                Pvp = reader.GetDecimal(3),
                                Iva = reader.GetDecimal(4)
                            };
                            productos.Add(prod);
                        }
                    }
                }
            }

            return productos;
        }
        public Productos ObtenerProductoPorId(int idProducto)
        {
            Productos producto = null;

            string query = @"
                SELECT p.id_producto, i.nombre_item, p.stock, i.pvp_item, i.porcentaje_iva_item
                FROM productos p
                JOIN items i ON p.id_item = i.id_item
                WHERE p.id_producto = @idProducto";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Solo debe devolver un producto
                        {
                            producto = new Productos
                            {
                                IdProducto = reader.GetInt32(0),
                                NombreItem = reader.GetString(1),
                                Stock = reader.GetInt32(2),
                                Pvp = reader.GetDecimal(3),
                                Iva = reader.GetDecimal(4)
                            };
                        }
                    }
                }
            }

            return producto;
        }

    }




}
