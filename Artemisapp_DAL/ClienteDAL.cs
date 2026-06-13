using Artemisapp_BE.Animales;
using Artemisapp_BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class ClienteDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Clientes.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta); 

            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Clientes"));
                doc.Save(ruta);
            }
        }

        // GUARDAR un cliente nuevo en el XML
        public bool GuardarCliente(Cliente cliente)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                XElement nuevoCliente = new XElement("Cliente",
                    new XElement("Dni", cliente.Dni),
                    new XElement("NroCte", cliente.NroCte),
                    new XElement("Nombre", cliente.Nombre),
                    new XElement("Apellido", cliente.Apellido),
                    new XElement("Direccion", cliente.Direccion),
                    new XElement("Telefono", cliente.Telefono),
                    new XElement("Email", cliente.Email)
                );

                doc.Root.Add(nuevoCliente);
                doc.Save(ruta);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // OBTENER TODOS los clientes del XML
        public List<Cliente> ObtenerTodos()
        {
            InicializarXML();
            List<Cliente> lista = new List<Cliente>();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elemento in doc.Root.Elements("Cliente"))
            {
                Cliente c = new Cliente(
                    (string)elemento.Element("Dni"),
                    (string)elemento.Element("NroCte"),
                    (string)elemento.Element("Nombre"),
                    (string)elemento.Element("Apellido"),
                    (string)elemento.Element("Direccion"),
                    (string)elemento.Element("Telefono"),
                    (string)elemento.Element("Email"),
                    new List<Animal>() // la lista de mascotas se carga aparte
                );
                lista.Add(c);
            }

            return lista;
        }

        // BUSCAR un cliente por DNI
        public Cliente BuscarPorDNI(string dni)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elemento in doc.Root.Elements("Cliente"))
            {
                if ((string)elemento.Element("Dni") == dni)
                {
                    return new Cliente(
                        (string)elemento.Element("Dni"),
                        (string)elemento.Element("NroCte"),
                        (string)elemento.Element("Nombre"),
                        (string)elemento.Element("Apellido"),
                        (string)elemento.Element("Direccion"),
                        (string)elemento.Element("Telefono"),
                        (string)elemento.Element("Email"),
                        new List<Animal>()
                    );
                }
            }

            return null;
        }

        // ACTUALIZAR datos de un cliente
        public bool ActualizarCliente(Cliente cliente)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                foreach (XElement elemento in doc.Root.Elements("Cliente"))
                {
                    if ((string)elemento.Element("Dni") == cliente.Dni)
                    {
                        elemento.Element("NroCte").Value = cliente.NroCte;
                        elemento.Element("Nombre").Value = cliente.Nombre;
                        elemento.Element("Apellido").Value = cliente.Apellido;
                        elemento.Element("Direccion").Value = cliente.Direccion;
                        elemento.Element("Telefono").Value = cliente.Telefono;
                        elemento.Element("Email").Value = cliente.Email;

                        doc.Save(ruta);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ELIMINAR un cliente por DNI
        public bool EliminarCliente(string dni)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                foreach (XElement elemento in doc.Root.Elements("Cliente"))
                {
                    if ((string)elemento.Element("Dni") == dni)
                    {
                        elemento.Remove();
                        doc.Save(ruta);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
