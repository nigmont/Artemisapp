using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class PermisoDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Permisos.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Permisos"));
                doc.Save(ruta);
            }
        }

        public List<XElement> ObtenerTodosCrudos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Permiso").ToList();
        }

        public XElement BuscarPorIdCrudo(long id)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Permiso")
                      .FirstOrDefault(x => (long)x.Element("Id") == id);
        }

        public bool GuardarCrudo(XElement nuevoPermiso)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoPermiso);
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
