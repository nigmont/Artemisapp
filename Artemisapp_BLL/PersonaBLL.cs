using Artemisapp_BE.Personas;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class PersonaBLL
    {
        
        PersonaDAL dal = new PersonaDAL(); // DAL para acceder a los datos de las personas
        
        PersonaMapper mapper = new PersonaMapper(); // Mapper para convertir entre XML y entidad de negocio

        public bool RegistrarUsuario(Persona persona)
        {
            return mapper.Guardar(persona);
        }

        public bool ModificarUsuario(Persona persona)
        {
            return false; // pensar como implementarlo
        }

        public bool EliminarUsuario(string dni)
        {
            return mapper.Eliminar(dni);
        }

        public Persona BuscarUsuarioPorDNI(string dni)
        {
            return mapper.BuscarPorDNI(dni);
        }

        public List<Persona> ObtenerTodosLosUsuarios()
        {
            return mapper.ObtenerTodas();
        }
    }
}