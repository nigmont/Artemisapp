using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class FacturaDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Facturas.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Facturas"));
                doc.Save(ruta);
            }
        }

        // CRUDO: devuelve todos los nodos <Factura> sin mapear
        public List<XElement> ObtenerTodasCrudas()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Factura").ToList();
        }

        // CRUDO: devuelve el nodo de una factura por Id
        public XElement BuscarPorIdCrudo(int id)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Factura")
                      .FirstOrDefault(x => (int)x.Element("Id") == id);
        }

        // CRUDO: recibe un nodo ya armado y lo guarda
        public bool GuardarCrudo(XElement nuevaFactura)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevaFactura);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Devuelve el Id más alto guardado (para autonumerar la próxima factura)
        public int ObtenerUltimoId()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            var ids = doc.Root.Elements("Factura").Select(x => (int)x.Element("Id"));
            return ids.Any() ? ids.Max() : 0;
        }
    }
}

