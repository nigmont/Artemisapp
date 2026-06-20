using Artemisapp_BE;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class UsuarioClaveBLL
    {
        UsuarioClavesMapper mapper = new UsuarioClavesMapper();
            

        // Registrar un usuario nuevo
        public bool RegistrarUsuario(UsuarioClaves usuario)
        {
            return mapper.Guardar(usuario);
        }


        // Obtener todos los usuarios
        public List<UsuarioClaves> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }

        // LOGIN: valida usuario + contraseña
        public bool IniciarSesion(string usuario, string password)
        {
            UsuarioClaves encontrado = mapper.BuscarPorNombreUsuario(usuario);

            // 1. ¿Existe ese usuario?
            if (encontrado == null)
                return false;

            // 2. ¿La contraseña coincide?
            if (encontrado.Password != password)
                return false;

            // 3. ¿La cuenta está activa y no bloqueada?
            if (!encontrado.Activo || encontrado.Bloqueado)
                return false;

            // Si pasó todo, el login es válido
            return true;
        }
    }
}
