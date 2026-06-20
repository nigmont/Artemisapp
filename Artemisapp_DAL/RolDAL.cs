using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class RolDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Roles.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Roles"));
                doc.Save(ruta);
            }
        }

        public List<XElement> ObtenerTodosCrudos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Rol").ToList();
        }

        public XElement BuscarPorIdCrudo(long id)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Rol")
                      .FirstOrDefault(x => (long)x.Element("Id") == id);
        }

        public bool GuardarCrudo(XElement nuevoRol)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoRol);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
