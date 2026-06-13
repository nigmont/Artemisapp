using Artemisapp_BE.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE.Animales
{
    public class Gato: Animal
    {
        private Boolean _castrado;
        private Boolean _vacunado;
        private Boolean _medicado;

        public Boolean Castrado { get { return _castrado; } set { _castrado = value; } }
        public Boolean Vacunado { get { return _vacunado; } set { _vacunado = value; } }
        public Boolean Medicado { get { return _medicado; } set { _medicado = value; } }

        public Gato(string nombre, int edad, double peso, string raza, string nroCte,
                        Boolean castrado, Boolean vacunado, Boolean medicado) :
                        base(nombre, edad, peso, raza, nroCte)
        {
            _castrado = castrado;
            _vacunado = vacunado;
            _medicado = medicado;
        }
    }
}
