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

        // CRUDO: devuelve todos los nodos <Producto> sin mapear
        public List<XElement> ObtenerTodosCrudos()
        {
            inicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Producto").ToList();
        }

        // CRUDO: devuelve el nodo de un producto por ID
        public XElement BuscarPorIDCrudo(string id)
        {
            inicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Producto")
                      .FirstOrDefault(x => (string)x.Element("ID-Producto") == id);
        }

        // CRUDO: recibe un nodo ya armado y lo guarda
        public bool GuardarCrudo(XElement nuevoProducto)
        {
            try
            {
                inicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoProducto);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: reemplaza el nodo existente (busca por ID) por el nuevo
        public bool ActualizarCrudo(XElement productoActualizado)
        {
            try
            {
                inicializarXML();
                XDocument doc = XDocument.Load(ruta);
                string id = (string)productoActualizado.Element("ID-Producto");

                XElement elem = doc.Root.Elements("Producto")
                                  .FirstOrDefault(x => (string)x.Element("ID-Producto") == id);
                if (elem != null)
                {
                    elem.ReplaceWith(productoActualizado);
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: elimina el nodo de un producto por ID
        public bool EliminarCrudo(string id)
        {
            try
            {
                inicializarXML();
                XDocument doc = XDocument.Load(ruta);

                XElement elem = doc.Root.Elements("Producto")
                                  .FirstOrDefault(x => (string)x.Element("ID-Producto") == id);
                if (elem != null)
                {
                    elem.Remove();
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }



    }
}
