using Artemisapp_BE;
using Artemisapp_DAL;
using System;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class TurnosBLL
    {
        TurnoDAL dal = new TurnoDAL();

        public bool RegistrarTurnoInmediato(Turno turno)
        {
            return dal.GuardarTurno(turno);
        }

        public bool ProgramarTurnoAnticipado(Turno turno)
        {
            return dal.GuardarTurno(turno);
        }

        public bool ModificarTurno(Turno turno)
        {
            return dal.ModificarTurno(turno);
        }

        public bool CancelarTurno(string idTurno)
        {
            return dal.CancelarTurno(idTurno);
        }

        public bool VerificarDisponibilidad(string dni, DateTime fecha, string horario)
        {
            return dal.VerificarDisponibilidad(dni, fecha, horario);
        }

        public List<Turno> ObtenerTurnosPorDNI(string dni)
        {
            return dal.BuscarPorDNI(dni);
        }
    }
}