using Artemisapp_BE;
using Artemisapp_BE.Composite;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class RolBLL
    {
        RolMapper mapper = new RolMapper();

        public bool RegistrarRol(BERol rol)
        {
            return mapper.Guardar(rol);
        }

        public BERol BuscarPorId(long id)
        {
            return mapper.BuscarPorId(id);
        }

        public List<BERol> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }

        public void CrearRolAdministrador()
        {
            // Si ya hay roles cargados, no se hace nada (evita duplicados)
            if (ObtenerTodos().Count > 0)
                return;

            // El Administrador tiene TODOS los permisos (1 al 8)
            PermisoBLL permisoBLL = new PermisoBLL();
            BERol admin = new BERol(1, "Administrador");

            for (long id = 1; id <= 7; id++) // IDs de los permisos van del 1 al 8
            {
                BEPermiso permiso = permisoBLL.BuscarPorId(id); // Busca el permiso por su ID
                if (permiso != null) // Si el permiso existe, lo agrega al rol
                    admin.Agregar(permiso); //  Agrega el permiso al rol Administrador
            }

            RegistrarRol(admin);
        }

        public bool ActualizarRol(BERol rol)
        {
            return mapper.Actualizar(rol);
        }

        // Modifica el nombre de un rol (conserva sus permisos)
        public bool ModificarNombreRol(long id, string nuevoNombre)
        {
            BERol rol = mapper.BuscarPorId(id);
            if (rol == null)
                return false;

            rol.Nombre = nuevoNombre;
            return mapper.Actualizar(rol);
        }

        // Devuelve true si algún usuario tiene asignado este rol
        public bool RolEstaEnUso(long idRol, out string nombreUsuarioQueLoUsa)
        {
            UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();
            foreach (UsuarioClaves u in usuarioBLL.ObtenerTodos())
            {
                foreach (BERol r in u.Roles)
                {
                    if (r.Id == idRol)
                    {
                        nombreUsuarioQueLoUsa = u.Usuario;
                        return true;
                    }
                }
            }
            nombreUsuarioQueLoUsa = null;
            return false;
        }

        public bool EliminarRol(long id)
        {
            return mapper.Eliminar(id);
        }
    }
}
