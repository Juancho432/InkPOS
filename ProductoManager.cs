using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkPos
{
    public class ProductoManager
    {
        private List<Producto> productos = new List<Producto>();

        public string AgregarProducto(Producto nuevoProducto)
        {
            if (string.IsNullOrWhiteSpace(nuevoProducto.Codigo) ||
                string.IsNullOrWhiteSpace(nuevoProducto.Nombre) ||
                nuevoProducto.Precio <= 0 ||
                nuevoProducto.Cantidad < 0)
            {
                return "Error: Hay campos faltantes o valores inválidos.";
            }

            var productoExistente = productos.FirstOrDefault(p => p.Codigo == nuevoProducto.Codigo);
            if (productoExistente != null)
            {
                return "Error: El producto ya está registrado en la base de datos.";
            }

            productos.Add(nuevoProducto);
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

            var productoExistente = productos.FirstOrDefault(p => p.Codigo == productoModificado.Codigo);
            if (productoExistente == null)
            {
                return "Error: Producto no encontrado.";
            }

            productoExistente.Nombre = productoModificado.Nombre;
            productoExistente.Precio = productoModificado.Precio;
            productoExistente.Cantidad = productoModificado.Cantidad;

            return "Cambios guardados correctamente.";
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
