using Artemisapp_BE;
using System;
using Artemisapp_DAL;
using System.Collections.Generic;
using System.Globalization;

namespace Artemisapp_BLL
{
    public class ProductoBLL
    {
        ProductoDAL dal = new ProductoDAL();

        public bool RegistrarProducto(Producto producto)
        {
            return dal.guardarProducto(producto);
        }

        public bool ActualizarProducto(Producto producto)
        {
            return dal.actualizarProducto(producto);
        }

        public bool EliminarProducto(string id)
        {
            return dal.eliminarProducto(id);
        }

        public Producto BuscarProductoPorId(string id)
        {
            return dal.buscarPorID(id);
        }

        public List<Producto> ObtenerTodos()
        {
            return dal.obtenerTodos();
        }
    }
}
