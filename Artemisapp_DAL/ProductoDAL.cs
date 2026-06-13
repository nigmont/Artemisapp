using Artemisapp_BE.Animales;
using Artemisapp_BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace Artemisapp_DAL
{
    public class ProductoDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Productos.xml");

        private void inicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Productos"));
                doc.Save(ruta);
            }
        }

        // GUARDAR un producto nuevo en el XML

        public bool guardarProducto(Producto producto)
        {
            try
            {
                inicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement nuevoProducto = new XElement("Producto",
                    new XElement("ID-Producto", producto.IdProducto),
                    new XElement("Nombre", producto.Nombre),
                    new XElement("Descripcion", producto.Descripcion),
                    new XElement("Categoria", producto.Categoria),
                    new XElement("Vencimiento", producto.FechaDeVencimiento),
                    new XElement("Precio", producto.Precio),
                    new XElement("Proveedor", producto.Proveedor),
                    new XElement("Stock", producto.Stock)
                );
                doc.Root.Add(nuevoProducto);
                doc.Save(ruta);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*
         * private string _idProducto;
        private string _nombre;
        private string _descripcion;
        private string _categoria;
        private DateTime _fechaDeVencimiento;
        private Double _precio;
        private string _proveedor;
        private int _stock;
        */

        public List<Producto> obtenerTodos()
        {
            inicializarXML();
            List<Producto> lista = new List<Producto>();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elem in doc.Root.Elements("Producto"))
            {
                Producto prod = new Producto(
                    (string)elem.Element("ID-Producto"),
                    (string)elem.Element("Nombre"),
                    (string)elem.Element("Descripcion"),
                    (string)elem.Element("Categoria"),
                    (DateTime)elem.Element("Vencimiento"),
                    (double)elem.Element("Precio"),
                    (string)elem.Element("Proveedor"),
                    (int)(elem.Element("Stock"))
                );
                lista.Add(prod);
            }
            return lista;

        }

        public Producto buscarPorID(string id)
        {
            inicializarXML();
            XDocument doc = XDocument.Load(ruta);
            XElement elem = doc.Root.Elements("Producto").FirstOrDefault(x => (string)x.Element("ID-Producto") == id);
            if (elem != null)
            {
                return new Producto(
                    (string)elem.Element("ID-Producto"),
                    (string)elem.Element("Nombre"),
                    (string)elem.Element("Descripcion"),
                    (string)elem.Element("Categoria"),
                    (DateTime)elem.Element("Vencimiento"),
                    (double)elem.Element("Precio"),
                    (string)elem.Element("Proveedor"),
                    (int)(elem.Element("Stock"))
                );
            }
            return null;

        }

        public bool actualizarProducto(Producto producto)
        {
            try
            {
                inicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement elem = doc.Root.Elements("Producto").FirstOrDefault(x => (string)x.Element("ID-Producto") == producto.IdProducto);
                if (elem != null)
                {
                    elem.Element("Nombre").Value = producto.Nombre;
                    elem.Element("Descripcion").Value = producto.Descripcion;
                    elem.Element("Categoria").Value = producto.Categoria;
                    elem.Element("Precio").Value = producto.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    elem.Element("Vencimiento").Value = producto.FechaDeVencimiento.ToString("yyyy-MM-dd");
                    elem.Element("Proveedor").Value = producto.Proveedor;
                    elem.Element("Stock").Value = producto.Stock.ToString();
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool eliminarProducto(string id)
        {
            try
            {
                inicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement elem = doc.Root.Elements("Producto").FirstOrDefault(x => (string)x.Element("ID-Producto") == id);
                if (elem != null)
                {
                    elem.Remove();
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
