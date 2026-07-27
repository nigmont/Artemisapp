using Artemisapp_BE;
using System;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System.Collections.Generic;
using System.Globalization;

namespace Artemisapp_BLL
{
    public class ProductoBLL
    {
        ProductoDAL dal = new ProductoDAL();

        ProductoMapper mapper = new ProductoMapper();// Mapper para convertir entre Producto
                                                     // (entidad de negocio) y XElement (dato crudo)

        public bool RegistrarProducto(Producto producto)
        {
            return mapper.Guardar(producto);
        }

        public bool ActualizarProducto(Producto producto)
        {
            return mapper.Actualizar(producto);
        }

        public bool EliminarProducto(string id)
        {
            return mapper.Eliminar(id);
        }

        public Producto BuscarProductoPorId(string id)
        {
            return mapper.BuscarPorID(id);
        }

        public List<Producto> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }

        // Descuenta 1 unidad del stock del producto.
        // Devuelve el stock restante, o -1 si el producto no existe.
        public int DescontarUnidad(string id)
        {
            Producto producto = mapper.BuscarPorID(id);

            if (producto == null)
                return -1; // no existe el producto

            if (producto.Stock <= 0)
                return 0; // ya no hay unidades, no se descuenta nada

            producto.Stock = producto.Stock - 1;
            mapper.Actualizar(producto); // guarda el nuevo stock en el XML

            return producto.Stock;
        }

        // Devuelve los productos que vencen dentro de los próximos 7 días
        public List<Producto> ObtenerProximosAVencer()
        {
            List<Producto> proximos = new List<Producto>();
            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(7);

            foreach (Producto p in mapper.ObtenerTodos())
            {
                if (p.Stock > 0 &&
                    p.FechaDeVencimiento.Date >= hoy &&
                    p.FechaDeVencimiento.Date <= limite)
                {
                    proximos.Add(p);
                }
            }

            return proximos;
        }

        // Suma unidades al stock del producto.
        // Devuelve el stock resultante, o -1 si el producto no existe.
        public int AgregarStock(string id, int cantidad)
        {
            Producto producto = mapper.BuscarPorID(id);

            if (producto == null)
                return -1;

            if (cantidad <= 0)
                return producto.Stock; // no se suma nada raro (negativos o cero)

            producto.Stock = producto.Stock + cantidad;
            mapper.Actualizar(producto);

            return producto.Stock;
        }
    }
}
