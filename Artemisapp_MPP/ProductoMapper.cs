using Artemisapp_BE;
using Artemisapp_DAL;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Artemisapp_MPP
{
    public class ProductoMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public Producto ToEntity(XElement elem)
        {
            return new Producto(
                (string)elem.Element("ID-Producto"),
                (string)elem.Element("Nombre"),
                (string)elem.Element("Descripcion"),
                (string)elem.Element("Categoria"),
                (DateTime)elem.Element("Vencimiento"),
                (double)elem.Element("Precio"),
                (string)elem.Element("Proveedor"),
                (int)elem.Element("Stock")
            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Producto producto)
        {
            return new XElement("Producto",
                new XElement("ID-Producto", producto.IdProducto),
                new XElement("Nombre", producto.Nombre),
                new XElement("Descripcion", producto.Descripcion),
                new XElement("Categoria", producto.Categoria),
                new XElement("Vencimiento", producto.FechaDeVencimiento),
                new XElement("Precio", producto.Precio),
                new XElement("Proveedor", producto.Proveedor),
                new XElement("Stock", producto.Stock)
            );
        }

        public List<Producto> ObtenerTodos()
        {
            ProductoDAL dal = new ProductoDAL();
            List<Producto> lista = new List<Producto>();

            foreach (XElement elem in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public Producto BuscarPorID(string id)
        {
            ProductoDAL dal = new ProductoDAL();
            XElement elem = dal.BuscarPorIDCrudo(id);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(Producto producto)
        {
            ProductoDAL dal = new ProductoDAL();
            XElement nuevoProducto = ToXml(producto);
            return dal.GuardarCrudo(nuevoProducto);
        }

        public bool Actualizar(Producto producto)
        {
            ProductoDAL dal = new ProductoDAL();
            XElement productoActualizado = ToXml(producto);
            return dal.ActualizarCrudo(productoActualizado);
        }

        public bool Eliminar(string id)
        {
            ProductoDAL dal = new ProductoDAL();
            return dal.EliminarCrudo(id);
        }
   
    
    }
}
