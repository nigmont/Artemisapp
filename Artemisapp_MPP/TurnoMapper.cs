using Artemisapp_BE;
using Artemisapp_DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Artemisapp_MPP
{
    public class TurnoMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public Turno ToEntity(XElement elem)
        {
            return new Turno(
                (string)elem.Element("IdTurno"),
                (string)elem.Element("Dni"),
                (string)elem.Element("Estado"),
                DateTime.Parse((string)elem.Element("Fecha"), CultureInfo.InvariantCulture),
                (string)elem.Element("Horario"),
                (string)elem.Element("Motivo")
            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Turno turno)
        {
            return new XElement("Turno",
                new XElement("IdTurno", turno.IdTurno),
                new XElement("Dni", turno.Dni),
                new XElement("Estado", turno.Estado),
                new XElement("Fecha", turno.Fecha.ToString("yyyy-MM-dd")),
                new XElement("Horario", turno.Horario),
                new XElement("Motivo", turno.Motivo)
            );
        }


        public List<Turno> BuscarPorDNI(string dni)
        {
            TurnoDAL dal = new TurnoDAL();
            List<Turno> lista = new List<Turno>();

            foreach (XElement elem in dal.BuscarPorDNICrudo(dni))
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public List<Turno> ObtenerTodos()
        {
            TurnoDAL dal = new TurnoDAL();
            List<Turno> lista = new List<Turno>();

            foreach (XElement elem in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public bool Guardar(Turno turno)
        {
            TurnoDAL dal = new TurnoDAL();
            XElement nuevoTurno = ToXml(turno);
            return dal.GuardarCrudo(nuevoTurno);
        }

        public bool Actualizar(Turno turno)
        {
            TurnoDAL dal = new TurnoDAL();
            XElement turnoActualizado = ToXml(turno);
            return dal.ActualizarCrudo(turnoActualizado);
        }

        public bool Cancelar(string idTurno)
        {
            TurnoDAL dal = new TurnoDAL();
            return dal.CancelarCrudo(idTurno);
        }

        public bool VerificarDisponibilidad(string dni, DateTime fecha, string horario)
        {
            TurnoDAL dal = new TurnoDAL();
            return dal.VerificarDisponibilidad(dni, fecha, horario);
        }
   
    }
}