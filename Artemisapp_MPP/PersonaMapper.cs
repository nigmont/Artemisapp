using System.Xml.Linq;
using System.Collections.Generic;
using Artemisapp_DAL;
using Artemisapp_BE.Personas;

namespace Artemisapp_MPP
{
    public class PersonaMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public Persona ToEntity(XElement elemento)
        {
            return new Persona(
                (string)elemento.Element("Nombre"),
                (string)elemento.Element("Apellido"),
                (string)elemento.Element("DNI"),
                (string)elemento.Element("Telefono"),
                (string)elemento.Element("Correo")
            );
        }

        public List<Persona> ObtenerTodas()
        {
            PersonaDAL dal = new PersonaDAL(); // Aquí se podría usar inyección de dependencias
                                               // para no acoplar tanto el mapper al DAL
            List<Persona> lista = new List<Persona>(); // Lista vacía para llenar con las entidades de negocio

            foreach (XElement elemento in dal.ObtenerTodasCrudas()) // Recorremos cada elemento XML crudo
                                                                    // obtenido del DAL
            {
                lista.Add(ToEntity(elemento));
            }

            return lista;
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Persona persona)
        {
            return new XElement("Persona",
                new XElement("DNI", persona.DNI),
                new XElement("Nombre", persona.Nombre),
                new XElement("Apellido", persona.Apellido),
                new XElement("Telefono", persona.Telefono),
                new XElement("Correo", persona.Correo)
            );
        }
    }
}