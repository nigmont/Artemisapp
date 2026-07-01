using Artemisapp_BE;
using Artemisapp_BE.Animales;
using Artemisapp_DAL;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Artemisapp_MPP
{
    public class ClienteMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public Cliente ToEntity(XElement elemento)
        {
            return new Cliente(
                (string)elemento.Element("Dni"),
                (string)elemento.Element("NroCte"),
                (string)elemento.Element("Nombre"),
                (string)elemento.Element("Apellido"),
                (string)elemento.Element("Direccion"),
                (string)elemento.Element("Telefono"),
                (string)elemento.Element("Email"),
                new List<Animal>(),
                (bool?)elemento.Element("Activo") ?? true

            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Cliente cliente)
        {
            return new XElement("Cliente",
                new XElement("Dni", cliente.Dni),
                new XElement("NroCte", cliente.NroCte),
                new XElement("Nombre", cliente.Nombre),
                new XElement("Apellido", cliente.Apellido),
                new XElement("Direccion", cliente.Direccion),
                new XElement("Telefono", cliente.Telefono),
                new XElement("Email", cliente.Email),
                new XElement("Activo", cliente.Activo)

            );
        }

        public List<Cliente> ObtenerTodos()
        {
            ClienteDAL dal = new ClienteDAL();
            List<Cliente> lista = new List<Cliente>();

            foreach (XElement elemento in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elemento));
            }

            return lista;
        }

        public Cliente BuscarPorDNI(string dni)
        {
            ClienteDAL dal = new ClienteDAL();
            XElement elemento = dal.BuscarPorDNICrudo(dni);

            if (elemento == null)
                return null;

            return ToEntity(elemento);
        }

        public bool Guardar(Cliente cliente)
        {
            ClienteDAL dal = new ClienteDAL();
            XElement nuevoCliente = ToXml(cliente);
            return dal.GuardarCrudo(nuevoCliente);
        }

        public bool Actualizar(Cliente cliente)
        {
            ClienteDAL dal = new ClienteDAL();
            XElement clienteActualizado = ToXml(cliente);
            return dal.ActualizarCrudo(clienteActualizado);
        }

        public bool Eliminar(string dni)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.EliminarCrudo(dni);
        }
    }
}
