using Artemisapp_BE;
using Artemisapp_BE.Animales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        // CRUDO: devuelve todos los nodos <Cliente> sin mapear
        public List<XElement> ObtenerTodosCrudos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Cliente").ToList();
        }

        // CRUDO: devuelve el nodo de un cliente por DNI
        public XElement BuscarPorDNICrudo(string dni)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elemento in doc.Root.Elements("Cliente"))
            {
                if ((string)elemento.Element("Dni") == dni)
                    return elemento;
            }
            return null;
        }

        // CRUDO: recibe un nodo ya armado y lo guarda
        public bool GuardarCrudo(XElement nuevoCliente)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoCliente);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: reemplaza el nodo existente (busca por DNI) por el nuevo
        public bool ActualizarCrudo(XElement clienteActualizado)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                string dni = (string)clienteActualizado.Element("Dni");

                foreach (XElement elemento in doc.Root.Elements("Cliente"))
                {
                    if ((string)elemento.Element("Dni") == dni)
                    {
                        elemento.ReplaceWith(clienteActualizado);
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

        // CRUDO: elimina el nodo de un cliente por DNI
        public bool EliminarCrudo(string dni)
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
            catch
            {
                return false;
            }
        }

       
    }
}
