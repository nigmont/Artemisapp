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

        // Carga el documento XML, si está corrupto realiza backup y crea uno nuevo vacío.
        private XDocument LoadOrCreateDocument()
        {
            InicializarXML();
            try
            {
                return XDocument.Load(ruta);
            }
            catch (System.Xml.XmlException)
            {
                // Archivo corrupto: mover a backup y crear uno nuevo
                try
                {
                    string backup = ruta + ".bak_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    if (File.Exists(ruta))
                        File.Move(ruta, backup);
                }
                catch
                {
                    // Ignorar errores de backup para no impedir la creación del nuevo archivo
                }

                var doc = new XDocument(new XElement("Permisos"));
                try { doc.Save(ruta); } catch { /* si falla, no hay mucho que hacer aquí */ }
                return doc;
            }
        }

        public List<XElement> ObtenerTodosCrudos()
        {
            XDocument doc = LoadOrCreateDocument();
            return doc.Root.Elements("Permiso").ToList();
        }

        public XElement BuscarPorIdCrudo(long id)
        {
            XDocument doc = LoadOrCreateDocument();
            return doc.Root.Elements("Permiso")
                      .FirstOrDefault(x => (long)x.Element("Id") == id);
        }

        public bool GuardarCrudo(XElement nuevoPermiso)
        {
            try
            {
                XDocument doc = LoadOrCreateDocument();
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
