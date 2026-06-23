using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Artemisapp_BE.Composite;
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class RolMapper
    {
        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(BERol rol)
        {
            // Armamos el nodo <Permisos> con los Id de cada permiso del rol
            XElement permisos = new XElement("Permisos");
            foreach (BEComposite hijo in rol.ObtenerHijos())
            {
                permisos.Add(new XElement("IdPermiso", hijo.Id));
            }

            return new XElement("Rol",
                new XElement("Id", rol.Id),
                new XElement("Nombre", rol.Nombre),
                permisos
            );
        }

        // De dato crudo (XML) → entidad de negocio
        public BERol ToEntity(XElement elem)
        {
            BERol rol = new BERol(
                (long)elem.Element("Id"),
                (string)elem.Element("Nombre")
            );

            // Para cada IdPermiso guardado, buscamos el permiso completo y lo agregamos
            PermisoMapper permisoMapper = new PermisoMapper();
            foreach (XElement idElem in elem.Element("Permisos").Elements("IdPermiso"))
            {
                long idPermiso = (long)idElem;
                BEPermiso permiso = permisoMapper.BuscarPorId(idPermiso);
                if (permiso != null)
                    rol.Agregar(permiso);
            }

            return rol;
        }

        public List<BERol> ObtenerTodos()
        {
            RolDAL dal = new RolDAL();
            List<BERol> lista = new List<BERol>();

            foreach (XElement elem in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public BERol BuscarPorId(long id)
        {
            RolDAL dal = new RolDAL();
            XElement elem = dal.BuscarPorIdCrudo(id);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(BERol rol)
        {
            RolDAL dal = new RolDAL();
            XElement nuevoRol = ToXml(rol);
            return dal.GuardarCrudo(nuevoRol);
        }

        public bool Actualizar(BERol rol)
        {
            RolDAL dal = new RolDAL();
            XElement rolActualizado = ToXml(rol);
            return dal.ActualizarCrudo(rolActualizado);
        }
    }
}

