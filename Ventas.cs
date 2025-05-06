using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace InkPos
{
    public class Ventas
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin;Database=InkPosDB";

        // Método para insertar una venta
        public int InsertarVenta(int clienteId, DateTime fechaVenta, decimal totalVenta)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Inserción de la venta en la tabla Ventas
                string query = "INSERT INTO Ventas (ClienteId, FechaVenta, TotalVenta) " +
                               "VALUES (@ClienteId, @FechaVenta, @TotalVenta) " +
                               "RETURNING VentaId";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    // Parametrizamos la consulta
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    command.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                    command.Parameters.AddWithValue("@TotalVenta", totalVenta);

                    // Ejecutamos el comando y obtenemos el ID de la venta insertada
                    int ventaId = (int)command.ExecuteScalar(); // Esto devuelve el ID generado por la venta insertada

                    return ventaId; // Retornamos el ID para usarlo en la inserción de los detalles
                }
            }
        }
        // Método para insertar detalles de la venta
        public void InsertarDetalleVenta(int ventaId, List<DetalleVenta> detalles)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Insertamos cada detalle de la venta
                foreach (var detalle in detalles)
                {
                    string query = "INSERT INTO DetalleVentas (VentaId, CodigoProducto, NombreProducto, Cantidad, Valor) " +
                                   "VALUES (@VentaId, @CodigoProducto, @NombreProducto, @Cantidad, @Valor)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Parametrizamos la consulta
                        command.Parameters.AddWithValue("@VentaId", ventaId);
                        command.Parameters.AddWithValue("@CodigoProducto", detalle.Codigo);
                        command.Parameters.AddWithValue("@NombreProducto", detalle.Producto);
                        command.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                        command.Parameters.AddWithValue("@Valor", detalle.Valor);

                        // Ejecutamos la consulta para insertar el detalle
                        command.ExecuteNonQuery();
                    }
                }
            }
        }


    }


}
