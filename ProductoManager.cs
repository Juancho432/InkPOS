using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class ProductoManager
    {

        public string AgregarProducto(Producto nuevoProducto)
        {
            if (string.IsNullOrWhiteSpace(nuevoProducto.Codigo) ||
        string.IsNullOrWhiteSpace(nuevoProducto.Nombre) ||
        nuevoProducto.Precio <= 0 ||
        nuevoProducto.Cantidad < 0)
            {
                return "Error: Hay campos faltantes o valores inválidos.";
            }

            // Verificar si el producto ya existe en la base de datos
            if (ConexionDB.ComprobarCodigoProducto(nuevoProducto.Codigo))
            {
                return "Error: El producto ya está registrado en la base de datos.";
            }

            // Aquí deberías insertar el producto en la base de datos
            // Por ahora asumimos que solo se añade a una lista en memoria (no es lo ideal)
            // producto.Add(nuevoProducto);

            return "Producto registrado correctamente.";
        }

        public string ModificarProducto(Producto productoModificado)
        {
            if (string.IsNullOrWhiteSpace(productoModificado.Codigo) ||
                string.IsNullOrWhiteSpace(productoModificado.Nombre) ||
                productoModificado.Precio <= 0 ||
                productoModificado.Cantidad < 0)
            {
                return "Error: Hay campos faltantes o valores inválidos.";
            }

            bool exito = ConexionDB.ModificarProductoEnDB(productoModificado);
            return exito ? "Cambios guardados correctamente." : "Error: Producto no encontrado.";
        }

        public List<Producto> ObtenerProductos()
        {
            return ConexionDB.ObtenerProductosDesdeDB();
        }
    }
}
