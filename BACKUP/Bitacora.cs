using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace BACKUP
{
    // Clase de persistencia de datos de la bitácora en un archivo XML 
    public class Bitacora 
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Bitacora.xml");
        // ruta es la ruta completa del archivo XML donde se guardarán los eventos de la bitácora

        private void InicializarXML() // Crea el archivo XML si no existe
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Eventos"));
                doc.Save(ruta);
            }
        }

        // Registra un nuevo evento en la bitácora
        public void RegistrarEvento(EventoBitacora evento)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);

            XElement nuevo = new XElement("Evento",
                new XElement("FechaHora", evento.FechaHora.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
                new XElement("Usuario", evento.Usuario),
                new XElement("Evento", evento.Evento)
            );

            doc.Root.Add(nuevo);
            doc.Save(ruta);
        }

        // Devuelve todos los eventos registrados
        public List<EventoBitacora> ObtenerTodos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta); // doc es un objeto que representa el documento XML
                                                  // cargado desde la ruta especificada

            // lista es una lista de objetos EventoBitacora que se llenará con los eventos leídos del archivo XML
            List<EventoBitacora> lista = new List<EventoBitacora>();

            foreach (XElement elem in doc.Root.Elements("Evento"))
            {
                DateTime fecha = DateTime.ParseExact(
                    (string)elem.Element("FechaHora"),
                    "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture);

                EventoBitacora ev = new EventoBitacora(
                    fecha,
                    (string)elem.Element("Usuario"),
                    (string)elem.Element("Evento")  
                );

                lista.Add(ev);
            }

            return lista;
        }
    }
}
