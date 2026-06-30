using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace REPORTES
{
    public class ReporteTurnos
    {
        // Devuelve cuántos turnos hay de cada estado
        public Dictionary<string, int> ContarTurnosPorEstado()
        {
            // Se empieza con los 4 estados en 0 (para que siempre aparezcan,
            // aunque no haya turnos de ese estado)

            Dictionary<string, int> conteo = new Dictionary<string, int>();
            conteo["Pendiente"] = 0;
            conteo["Atendido"] = 0;
            conteo["Cancelado"] = 0;
            conteo["Ausente"] = 0;

            // se traen todos los turnos
            TurnosBLL bll = new TurnosBLL();
            List<Turno> turnos = bll.ObtenerTodos();

            // se cuenta cuántos hay de cada estado
            foreach (Turno t in turnos)
            {
                if (conteo.ContainsKey(t.Estado))
                    conteo[t.Estado] = conteo[t.Estado] + 1;
            }

            return conteo;
        }

        // Cuenta cuántos turnos hay en cada día de la semana
        public Dictionary<string, int> ContarTurnosPorDiaSemana()
        {
            // Arrancamos los días en 0 para que siempre aparezcan
            Dictionary<string, int> conteo = new Dictionary<string, int>();
            conteo["Lunes"] = 0;
            conteo["Martes"] = 0;
            conteo["Miércoles"] = 0;
            conteo["Jueves"] = 0;
            conteo["Viernes"] = 0;
            conteo["Sábado"] = 0;
            conteo["Domingo"] = 0;

            TurnosBLL bll = new TurnosBLL();
            List<Turno> turnos = bll.ObtenerTodos();

            foreach (Turno t in turnos)
            {
                // Traducimos el día de la semana de la fecha del turno
                string dia = TraducirDia(t.Fecha.DayOfWeek);
                if (conteo.ContainsKey(dia))
                    conteo[dia] = conteo[dia] + 1;
            }

            return conteo;
        }

        // Traduce el día de la semana de inglés a español
        private string TraducirDia(System.DayOfWeek dia)
        {
            switch (dia)
            {
                case System.DayOfWeek.Monday: return "Lunes";
                case System.DayOfWeek.Tuesday: return "Martes";
                case System.DayOfWeek.Wednesday: return "Miércoles";
                case System.DayOfWeek.Thursday: return "Jueves";
                case System.DayOfWeek.Friday: return "Viernes";
                case System.DayOfWeek.Saturday: return "Sábado";
                case System.DayOfWeek.Sunday: return "Domingo";
                default: return "";
            }
        }

        public int ObtenerCantidadTurnosHoy()
        {
            TurnosBLL bll = new TurnosBLL();
            List<Turno> turnos = bll.ObtenerTodos();

            DateTime hoy = DateTime.Today; // Trae la fecha actual a las 00:00:00

            // Filtra y cuenta los turnos que coincidan exactamente con el día de hoy
            return turnos.Count(t => t.Fecha.Date == hoy);
        }

        // 2. Busca el horario más próximo que esté en estado "Pendiente" hoy
        public string ObtenerProximoTurno()
        {
            TurnosBLL bll = new TurnosBLL();
            List<Turno> turnos = bll.ObtenerTodos();

            DateTime ahora = DateTime.Now;

            var proximo = turnos
                .Where(t => t.Fecha.Date == ahora.Date && t.Estado == "Pendiente")
                .Select(t => {
                    // Combinamos tu propiedad Fecha (yyyy-MM-dd) con el string Horario (HH:mm)
                    // para construir un DateTime real y poder comparar las horas correctamente.
                    DateTime fechaYHoraCompleta = t.Fecha.Date;
                    try
                    {
                        TimeSpan horaTime = TimeSpan.Parse(t.Horario);
                        fechaYHoraCompleta = fechaYHoraCompleta.Add(horaTime);
                    }
                    catch { /* Por si hay algún formato de hora extraño en el XML */ }

                    return new { TurnoObjeto = t, HorarioReal = fechaYHoraCompleta };
                })
                .Where(x => x.HorarioReal > ahora) // Que la hora del turno sea mayor a la actual
                .OrderBy(x => x.HorarioReal)       // Ordena para dejar el más cercano primero
                .FirstOrDefault();

            if (proximo != null)
            {
                // Retorna un texto limpio con el horario y el DNI del paciente
                return $"{proximo.TurnoObjeto.Horario} hs - DNI: {proximo.TurnoObjeto.Dni}";
            }

            return "No hay más turnos pendientes";
        }
    }
}

