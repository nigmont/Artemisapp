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
        private string _nombreMascota;    // NUEVO: qué mascota se atendió
        private DateTime _fechaDeConsulta;
        private string _estudios;
        private string _internaciones;
        private string _observaciones;
        private double _montoConsulta;    // NUEVO: total del cierre de consulta

        public string Dni { get { return _dni; } set { _dni = value; } }
        public string IdHistoria { get { return _idHistoria; } set { _idHistoria = value; } }
        public string NombreMascota { get { return _nombreMascota; } set { _nombreMascota = value; } }
        public DateTime FechaDeConsulta { get { return _fechaDeConsulta; } set { _fechaDeConsulta = value; } }
        public string Estudios { get { return _estudios; } set { _estudios = value; } }
        public string Internaciones { get { return _internaciones; } set { _internaciones = value; } }
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; } }
        public double MontoConsulta { get { return _montoConsulta; } set { _montoConsulta = value; } }

        public HistoriaClinica(string dni, string idHistoria, string nombreMascota,
                               DateTime fechaDeConsulta, string estudios, string internaciones,
                               string observaciones, double montoConsulta)
        {
            _dni = dni;
            _idHistoria = idHistoria;
            _nombreMascota = nombreMascota;
            _fechaDeConsulta = fechaDeConsulta;
            _estudios = estudios;
            _internaciones = internaciones;
            _observaciones = observaciones;
            _montoConsulta = montoConsulta;
        }
    }
}
