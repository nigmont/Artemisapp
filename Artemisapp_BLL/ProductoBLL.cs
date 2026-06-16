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
    }
}
