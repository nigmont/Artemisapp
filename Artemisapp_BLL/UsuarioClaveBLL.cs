using Artemisapp_BE;
using Artemisapp_MPP;
using SEGURIDAD; // referencia a la clase Encriptacion
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class UsuarioClaveBLL
    {
        UsuarioClavesMapper mapper = new UsuarioClavesMapper();
            

        // Registrar un usuario nuevo
        public bool RegistrarUsuario(UsuarioClaves usuario)
        {
            // Ciframos la contraseña antes de guardarla
            usuario.Password = Encriptacion.EncriptarPassword(usuario.Password);
            
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

            // 2. ¿La contraseña coincide? (ciframos lo escrito y comparamos contra lo guardado, que está cifrado)
            string passwordCifrada = Encriptacion.EncriptarPassword(password);
            if (encontrado.Password != passwordCifrada)
                return false;

            // 3. ¿La cuenta está activa y no bloqueada?
            if (!encontrado.Activo || encontrado.Bloqueado)
                return false;

            // Si pasó todo, el login es válido
            return true;
        }

        public UsuarioClaves ObtenerPorNombreUsuario(string usuario)
        {
            return mapper.BuscarPorNombreUsuario(usuario);
        }

        public bool ActualizarUsuario(UsuarioClaves usuario)
        {
            return mapper.Actualizar(usuario);
        }

        public bool EliminarUsuario(string nombreUsuario)
        {
            return mapper.Eliminar(nombreUsuario);
        }

        // Modifica DNI y, opcionalmente, la contraseña de un usuario existente.
        // Si nuevaPassword viene vacía, se conserva la contraseña actual (no se toca).
        public bool ModificarDatosUsuario(string nombreUsuario, string nuevaPassword, string dni)
        {
            UsuarioClaves existente = mapper.BuscarPorNombreUsuario(nombreUsuario);
            if (existente == null)
                return false;

            if (!string.IsNullOrEmpty(nuevaPassword))
                existente.Password = Encriptacion.EncriptarPassword(nuevaPassword);

            existente.Dni = dni;
            return mapper.Actualizar(existente);
        }
    }
}
