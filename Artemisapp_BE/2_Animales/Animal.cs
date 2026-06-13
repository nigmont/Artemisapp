using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE.Animales
{
    public class Animal 
    {
        private string _nombre;
        private int _edad;
        private double _peso;
        private string _raza;
        private string _propietario;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int Edad { get { return _edad; } set { _edad = value; } }
        public double Peso { get { return _peso; } set { _peso = value; } }
        public string Raza { get { return _raza; } set { _raza = value; } }
        public string NroCte { get { return _propietario; } set { _propietario = value; } }

        public Animal(string nombre, int edad, double peso, string raza, string nroCte) {
            _nombre = nombre;
            _edad = edad;
            _peso = peso;
            _raza = raza;
            _propietario = nroCte;
        }

    }
}
