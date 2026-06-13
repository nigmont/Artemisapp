using System;

namespace Artemisapp_BE.Personas
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _DNI;
        private string _telefono;
        private string _correo;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string DNI { get { return _DNI; } set { _DNI = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }

        public Persona(string nombre, string apellido, string dni, string telefono, string correo) {
            _nombre = nombre;
            _apellido = apellido;
            _DNI = dni;
            _telefono = telefono;
            _correo = correo;
        }

        // ══ MÉTODOS ══
        public bool IniciarSesion()
        {
            // lógica de inicio de sesión — se implementa en BLL
            return false;
        }
    }
}   