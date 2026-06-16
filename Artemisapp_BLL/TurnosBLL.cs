using Artemisapp_BE;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class TurnosBLL
    {
        TurnoDAL dal = new TurnoDAL();
        TurnoMapper mapper = new TurnoMapper();

        public bool RegistrarTurnoInmediato(Turno turno)
        {
            return mapper.Guardar(turno);
        }

        public bool ProgramarTurnoAnticipado(Turno turno)
        {
            return mapper.Guardar(turno);
        }

        public bool ModificarTurno(Turno turno)
        {
            return mapper.Actualizar(turno);
        }

        public bool CancelarTurno(string idTurno)
        {
            return mapper.Cancelar(idTurno);
        }

        public bool VerificarDisponibilidad(string dni, DateTime fecha, string horario)
        {
            return mapper.VerificarDisponibilidad(dni, fecha, horario);
        }

        public List<Turno> ObtenerTurnosPorDNI(string dni)
        {
            return mapper.BuscarPorDNI(dni);
        }
    }
}