using Artemisapp_BE.Composite;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class PermisoBLL
    {
        PermisoMapper mapper = new PermisoMapper();

        public bool RegistrarPermiso(BEPermiso permiso)
        {
            return mapper.Guardar(permiso);
        }

        public BEPermiso BuscarPorId(long id)
        {
            return mapper.BuscarPorId(id);
        }

        public List<BEPermiso> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }
    }
}
