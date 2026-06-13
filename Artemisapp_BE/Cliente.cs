using Artemisapp_BE.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE
{
    public class Cliente
    {
        private string _dni;
        private string _nroCte;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;
        private List<Animal> _mascotas;

        public string Dni { get { return _dni; } set { _dni = value; } }
        public string NroCte { get { return _nroCte; } set { _nroCte = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public List<Animal> Mascotas { get { return _mascotas; } set { _mascotas = value; } }

        public Cliente(string dni, string nroCte, string nombre, string apellido, string direccion, 
                        string telefono, string email, List<Animal> mascotas)
        {
            _dni = dni;
            _nroCte = nroCte;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _mascotas = mascotas;
        }
    }
}
