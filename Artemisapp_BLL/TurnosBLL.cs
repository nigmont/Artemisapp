using Artemisapp_BE;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Artemisapp_BLL
{
    public class TurnosBLL
    {
        // TurnoDAL dal = new TurnoDAL();
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

        // Metodo para obtener todos los turnos para el Dashboard 
        public List<Turno> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }

        // Verifica si el horario está libre para ese profesional en esa fecha.
        // Devuelve true si está disponible, false si ya hay un turno ocupándolo.
        public bool HorarioDisponible(string dniVeterinario, DateTime fecha, string horario)
        {
            foreach (Turno t in mapper.ObtenerTodos())
            {
                if (t.DniVeterinario == dniVeterinario &&
                    t.Fecha.Date == fecha.Date &&
                    t.Horario == horario &&
                    t.Estado != "Cancelado")
                {
                    return false; // ya hay un turno en ese horario con ese profesional
                }
            }

            return true;
        }

        // Devuelve los turnos pendientes de HOY que aún no pasaron,
        // ordenados por horario (el primero es el próximo a atender)
        public List<Turno> ObtenerColaDeHoy()
        {
            DateTime ahora = DateTime.Now;
            List<Turno> cola = new List<Turno>();

            foreach (Turno t in mapper.ObtenerTodos())
            {
                if (t.Fecha.Date != ahora.Date || t.Estado != "Pendiente")
                    continue;

                // Combinamos fecha + horario ("HH:mm") para poder comparar con la hora actual
                TimeSpan hora;
                if (!TimeSpan.TryParse(t.Horario, out hora))
                    continue; // horario con formato raro: lo salteamos

                DateTime momentoTurno = t.Fecha.Date.Add(hora);

                if (momentoTurno > ahora)
                    cola.Add(t);
            }

            // Ordenamos por horario: el más cercano primero
            return cola.OrderBy(t => TimeSpan.Parse(t.Horario)).ToList();
        }

        // Busca el turno de HOY, en estado Pendiente, para ese DNI de cliente
        public Turno BuscarTurnoPendienteDeHoy(string dni)
        {
            foreach (Turno t in mapper.ObtenerTodos())
            {
                if (t.Dni == dni && t.Fecha.Date == DateTime.Today && t.Estado == "Pendiente")
                    return t;
            }
            return null;
        }
    }
}