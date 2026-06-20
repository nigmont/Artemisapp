using System.Collections.Generic;
using System.Xml.Linq;
using Artemisapp_BE.Composite; // Para usar la clase BEPermiso y lo reconozca como tal
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class PermisoMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public BEPermiso ToEntity(XElement elem)
        {
            return new BEPermiso(
                (long)elem.Element("Id"),
                (string)elem.Element("Nombre")
            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(BEPermiso permiso)
        {
            return new XElement("Permiso",
                new XElement("Id", permiso.Id),
                new XElement("Nombre", permiso.Nombre)
            );
        }

        public List<BEPermiso> ObtenerTodos()
        {
            PermisoDAL dal = new PermisoDAL();
            List<BEPermiso> lista = new List<BEPermiso>();

            foreach (XElement elem in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public BEPermiso BuscarPorId(long id)
        {
            PermisoDAL dal = new PermisoDAL();
            XElement elem = dal.BuscarPorIdCrudo(id);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(BEPermiso permiso)
        {
            PermisoDAL dal = new PermisoDAL();
            XElement nuevoPermiso = ToXml(permiso);
            return dal.GuardarCrudo(nuevoPermiso);
        }
    }
}

