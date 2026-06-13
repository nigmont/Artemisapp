using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE
{
    public class HistoriaClinica
    {
        private string _dni;
        private string _idHistoria;
        private DateTime _fechaDeConsulta;
        private string _estudios;
        private string _internaciones;
        private string _observaciones;

        public string Dni { get { return _dni; } set { _dni = value; } }
        public string IdHistoria { get { return _idHistoria; } set { _idHistoria = value; } }
        public DateTime FechaDeConsulta { get { return _fechaDeConsulta; } set { _fechaDeConsulta = value; } }
        public string Estudios { get { return _estudios; } set { _estudios = value; } }
        public string Internaciones { get { return _internaciones; } set { _internaciones = value; } }
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; } }

        public HistoriaClinica(string dni, string idHistoria, DateTime fechaDeConsulta, string estudios, string internaciones, string observaciones)
        {
            _dni = dni;
            _idHistoria = idHistoria;
            _fechaDeConsulta = fechaDeConsulta;
            _estudios = estudios;
            _internaciones = internaciones;
            _observaciones = observaciones;
        }

    }
}
