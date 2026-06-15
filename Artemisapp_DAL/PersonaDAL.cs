using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Artemisapp_BE.Personas;

namespace Artemisapp_DAL
{
    public class PersonaDAL
    {
        // es la variable que guarda la ruta del archivo XML donde se almacenan los datos de las personas.
        // Se construye utilizando el directorio base de la aplicación y una subcarpeta "DATOS"
        // que contiene el archivo "Personas.xml".

        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Personas.xml");


        public List<XElement> ObtenerTodasCrudas() // Método que devuelve una lista de elementos XML crudos
                                                   // (sin mapear a entidades de negocio)
        {
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Persona").ToList();
        }

        public XElement BuscarPorDNICrudo(string dni)
        {
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elemento in doc.Root.Elements("Persona"))
            {
                if ((string)elemento.Element("DNI") == dni)
                {
                    return elemento;
                }
            }

            return null;
        }

        public bool GuardarCrudo(XElement nuevaPersona)
        {
            try
            {
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevaPersona);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCrudo(string dni)
        {
            try
            {
                XDocument doc = XDocument.Load(ruta);

                foreach (XElement elemento in doc.Root.Elements("Persona"))
                {
                    if ((string)elemento.Element("DNI") == dni)
                    {
                        elemento.Remove();
                        doc.Save(ruta);
                        return true;
                    }
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