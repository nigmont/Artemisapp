using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class VeterinarioDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Veterinarios.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Veterinarios"));
                doc.Save(ruta);
            }
        }

        public List<XElement> ObtenerTodosCrudos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Veterinario").ToList();
        }

        public XElement BuscarPorDNICrudo(string dni)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Veterinario")
                      .FirstOrDefault(x => (string)x.Element("DNI") == dni);
        }

        public bool GuardarCrudo(XElement nuevoVeterinario)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoVeterinario);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: reemplaza el nodo existente (busca por DNI) por el nuevo
        public bool ActualizarCrudo(XElement veterinarioActualizado)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                string dni = (string)veterinarioActualizado.Element("DNI");

                XElement elem = doc.Root.Elements("Veterinario")
                                  .FirstOrDefault(x => (string)x.Element("DNI") == dni);
                if (elem != null)
                {
                    elem.ReplaceWith(veterinarioActualizado);
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

        // CRUDO: elimina el nodo de un veterinario por DNI
        public bool EliminarCrudo(string dni)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                XElement elem = doc.Root.Elements("Veterinario")
                                  .FirstOrDefault(x => (string)x.Element("DNI") == dni);
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

