using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Artemisapp_BE;
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class UsuarioClavesMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public UsuarioClaves ToEntity(XElement elem)
        {
            return new UsuarioClaves(
                (string)elem.Element("Id"),
                (string)elem.Element("Usuario"),
                (string)elem.Element("Password"),
                (string)elem.Element("Dni"),
                (bool)elem.Element("Activo"),
                (bool)elem.Element("Bloqueado")
            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(UsuarioClaves usuario)
        {
            return new XElement("UsuarioClaves",
                new XElement("Id", usuario.Id),
                new XElement("Usuario", usuario.Usuario),
                new XElement("Password", usuario.Password),
                new XElement("Dni", usuario.Dni),
                new XElement("Activo", usuario.Activo),
                new XElement("Bloqueado", usuario.Bloqueado)
            );
        }

        public UsuarioClaves BuscarPorNombreUsuario(string nombreUsuario)
        {
            UsuarioClavesDAL dal = new UsuarioClavesDAL();
            XElement elem = dal.BuscarPorNombreUsuarioCrudo(nombreUsuario);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(UsuarioClaves usuario)
        {
            UsuarioClavesDAL dal = new UsuarioClavesDAL();
            XElement nuevoUsuario = ToXml(usuario);
            return dal.GuardarCrudo(nuevoUsuario);
        }

        public List<UsuarioClaves> ObtenerTodos()
        {
            UsuarioClavesDAL dal = new UsuarioClavesDAL();
            List<UsuarioClaves> lista = new List<UsuarioClaves>();

            foreach (XElement elem in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public UsuarioClaves BuscarPorUsuario(string usuario)
        {
            throw new NotImplementedException();
        }
    }
}