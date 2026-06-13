using System;
using System.Collections.Generic;
using System.IO;
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

        // GUARDAR una persona nueva en el XML
        public bool GuardarPersona(Persona persona)
        {
            try
            {
                XDocument doc = XDocument.Load(ruta);

                XElement nuevaPersona = new XElement("Persona",
                    new XElement("DNI", persona.DNI),
                    new XElement("Nombre", persona.Nombre),
                    new XElement("Apellido", persona.Apellido),
                    new XElement("Telefono", persona.Telefono),
                    new XElement("Correo", persona.Correo)
                );

                doc.Root.Add(nuevaPersona);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // OBTENER TODAS las personas del XML
        public List<Persona> ObtenerTodas()
        {
            List<Persona> lista = new List<Persona>();

            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elemento in doc.Root.Elements("Persona"))
            {
                Persona p = new Persona(
                    (string)elemento.Element("Nombre"),
                    (string)elemento.Element("Apellido"),
                    (string)elemento.Element("DNI"),
                    (string)elemento.Element("Telefono"),
                    (string)elemento.Element("Correo")
                );

                lista.Add(p);
            }

            return lista;
        }

        // BUSCAR una persona por DNI
        public Persona BuscarPorDNI(string dni)
        {
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elemento in doc.Root.Elements("Persona"))
            {
                if ((string)elemento.Element("DNI") == dni)
                {
                    Persona p = new Persona(
                        (string)elemento.Element("Nombre"),
                        (string)elemento.Element("Apellido"),
                        (string)elemento.Element("DNI"),
                        (string)elemento.Element("Telefono"),
                        (string)elemento.Element("Correo")
                    );
                    return p;
                }
            }

            return null;
        }

        // ELIMINAR una persona por DNI
        public bool EliminarPersona(string dni)
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