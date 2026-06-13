using Artemisapp_BE.Personas;
using Artemisapp_DAL;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class PersonaBLL
    {
        // Creamos una instancia de la DAL
        PersonaDAL dal = new PersonaDAL();

        public bool RegistrarUsuario(Persona persona)
        {
            return dal.GuardarPersona(persona);
        }

        public bool ModificarUsuario(Persona persona)
        {
            return false; // lo implementamos después
        }

        public bool EliminarUsuario(string dni)
        {
            return dal.EliminarPersona(dni);
        }

        public Persona BuscarUsuarioPorDNI(string dni)
        {
            return dal.BuscarPorDNI(dni);
        }

        public List<Persona> ObtenerTodosLosUsuarios()
        {
            return dal.ObtenerTodas();
        }
    }
}