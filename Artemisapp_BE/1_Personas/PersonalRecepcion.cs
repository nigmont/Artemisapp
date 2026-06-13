using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE.Personas
{
    public class PersonalRecepcion : Persona
    {
        public PersonalRecepcion(string nombre, string apellido, string dni, 
                                 string telefono, string correo) 
            : base(nombre, apellido, dni, telefono, correo) {
        }
    }
}
