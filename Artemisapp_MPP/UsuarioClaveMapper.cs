using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Artemisapp_BE;
using Artemisapp_BE.Composite;
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class UsuarioClavesMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public UsuarioClaves ToEntity(XElement elem)
        {
            UsuarioClaves usuario = new UsuarioClaves(
                (string)elem.Element("Id"),
                (string)elem.Element("Usuario"),
                (string)elem.Element("Password"),
                (string)elem.Element("Dni"),
                (bool)elem.Element("Activo"),
                (bool)elem.Element("Bloqueado")
            );

            // Reconstruir la lista de roles a partir de los IdRol guardados
            XElement roles = elem.Element("Roles");
            if (roles != null)
            {
                RolMapper rolMapper = new RolMapper();
                foreach (XElement idElem in roles.Elements("IdRol"))
                {
                    long idRol = (long)idElem;
                    BERol rol = rolMapper.BuscarPorId(idRol);
                    if (rol != null)
                        usuario.Roles.Add(rol);
                }
            }

            return usuario;
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(UsuarioClaves usuario)
        {
            // Armamos el nodo <Roles> con los Id de cada rol del usuario
            XElement roles = new XElement("Roles");
            foreach (BERol rol in usuario.Roles)
            {
                roles.Add(new XElement("IdRol", rol.Id));
            }

            return new XElement("UsuarioClaves",
                new XElement("Id", usuario.Id),
                new XElement("Usuario", usuario.Usuario),
                new XElement("Password", usuario.Password),
                new XElement("Dni", usuario.Dni),
                new XElement("Activo", usuario.Activo),
                new XElement("Bloqueado", usuario.Bloqueado),
                roles
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

        public bool Actualizar(UsuarioClaves usuario)
        {
            UsuarioClavesDAL dal = new UsuarioClavesDAL();
            XElement usuarioActualizado = ToXml(usuario);
            return dal.ActualizarCrudo(usuarioActualizado);
        }
    }
}