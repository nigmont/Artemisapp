using Artemisapp_BE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class TurnoDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Turnos.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("Turnos"));
                doc.Save(ruta);
            }
        }

        // GUARDAR un turno nuevo
        public bool GuardarTurno(Turno turno)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                XElement nuevoTurno = new XElement("Turno",
                    new XElement("IdTurno", turno.IdTurno),
                    new XElement("Dni", turno.Dni),
                    new XElement("Estado", turno.Estado),
                    new XElement("Fecha", turno.Fecha.ToString("yyyy-MM-dd")),
                    new XElement("Horario", turno.Horario),
                    new XElement("Motivo", turno.Motivo)
                );

                doc.Root.Add(nuevoTurno);
                doc.Save(ruta);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // OBTENER TODOS los turnos
        public List<Turno> ObtenerTodos()
        {
            InicializarXML();
            List<Turno> lista = new List<Turno>();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elem in doc.Root.Elements("Turno"))
            {
                Turno t = new Turno(
                    (string)elem.Element("IdTurno"),
                    (string)elem.Element("Dni"),
                    (string)elem.Element("Estado"),
                    DateTime.Parse((string)elem.Element("Fecha"), CultureInfo.InvariantCulture),
                    (string)elem.Element("Horario"),
                    (string)elem.Element("Motivo")
                );
                lista.Add(t);
            }
            return lista;
        }

        // BUSCAR turnos por DNI
        public List<Turno> BuscarPorDNI(string dni)
        {
            InicializarXML();
            List<Turno> lista = new List<Turno>();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elem in doc.Root.Elements("Turno"))
            {
                if ((string)elem.Element("Dni") == dni)
                {
                    Turno t = new Turno(
                        (string)elem.Element("IdTurno"),
                        (string)elem.Element("Dni"),
                        (string)elem.Element("Estado"),
                        DateTime.Parse((string)elem.Element("Fecha"), CultureInfo.InvariantCulture),
                        (string)elem.Element("Horario"),
                        (string)elem.Element("Motivo")
                    );
                    lista.Add(t);
                }
            }
            return lista;
        }

        // MODIFICAR un turno existente
        public bool ModificarTurno(Turno turno)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement elem = doc.Root.Elements("Turno").FirstOrDefault(x => (string)x.Element("IdTurno") == turno.IdTurno);

                if (elem != null)
                {
                    elem.Element("Dni").Value = turno.Dni;
                    elem.Element("Estado").Value = turno.Estado;
                    elem.Element("Fecha").Value = turno.Fecha.ToString("yyyy-MM-dd");
                    elem.Element("Horario").Value = turno.Horario;
                    elem.Element("Motivo").Value = turno.Motivo;
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // CANCELAR un turno por ID
        public bool CancelarTurno(string idTurno)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement elem = doc.Root.Elements("Turno").FirstOrDefault(x => (string)x.Element("IdTurno") == idTurno);

                if (elem != null)
                {
                    elem.Element("Estado").Value = "Cancelado";
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // VERIFICAR disponibilidad por fecha y horario
        public bool VerificarDisponibilidad(string dni, DateTime fecha, string horario)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);

            XElement elem = doc.Root.Elements("Turno").FirstOrDefault(x =>
                (string)x.Element("Dni") == dni &&
                (string)x.Element("Fecha") == fecha.ToString("yyyy-MM-dd") &&
                (string)x.Element("Horario") == horario &&
                (string)x.Element("Estado") != "Cancelado"
            );

            return elem == null; // true = disponible, false = ocupado
        }
    }
}