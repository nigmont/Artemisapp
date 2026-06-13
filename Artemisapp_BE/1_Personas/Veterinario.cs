using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE.Personas
{
    public class Veterinario : Persona
    {
        private string _nroLicencia;
        private string _especialidad;

        public string NroLicencia { get { return _nroLicencia; } set { _nroLicencia = value; } }
        public string Especialidad { get { return _especialidad; } set { _especialidad = value; } }

        public Veterinario(string nombre, string apellido, string dni, string telefono, string correo, 
                           string nroLicencia, string especialidad) 
                           : base(nombre, apellido, dni, telefono, correo) {
            _nroLicencia = nroLicencia;
            _especialidad = especialidad;
        }
    }
}
