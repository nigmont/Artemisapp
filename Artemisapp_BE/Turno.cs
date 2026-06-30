using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE
{
    public class Turno
    {
        private string _idTurno;
        private string _dni;
        private string _dniVeterinario;
        private string _estado;
        private DateTime _fecha;
        private string _horario;
        private string _motivo; //de la consulta

        public string IdTurno { get { return _idTurno; } set { _idTurno = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }

        public string DniVeterinario { get { return _dniVeterinario; } set { _dniVeterinario = value; } }
        public string Estado { get { return _estado; } set { _estado = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Horario { get { return _horario; } set { _horario = value; } }
        public string Motivo { get { return _motivo; } set { _motivo = value; } }

        public Turno(string idTurno, string dni, string dniVeterinario,string estado, DateTime fecha, string horario, string motivo)
        {
            _idTurno = idTurno;
            _dni = dni;
            _dniVeterinario = dniVeterinario;
            _estado = estado;
            _fecha = fecha;
            _horario = horario;
            _motivo = motivo;
        }

    }
}
