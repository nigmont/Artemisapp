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
        public void CrearPermisos()
        {
            // Si ya hay permisos cargados, no se hace nada (evita duplicados)
            if (ObtenerTodos().Count > 0)
                return;

            RegistrarPermiso(new BEPermiso(1, "Gestionar Clientes"));
            RegistrarPermiso(new BEPermiso(2, "Gestionar Turnos"));
            RegistrarPermiso(new BEPermiso(3, "Gestionar Historia Clínica"));
            RegistrarPermiso(new BEPermiso(4, "Gestionar Productos"));
            RegistrarPermiso(new BEPermiso(5, "Cobrar Consulta"));
            RegistrarPermiso(new BEPermiso(6, "Gestionar Usuarios"));
            RegistrarPermiso(new BEPermiso(7, "Gestionar Roles y Permisos"));
        }

    }
}
