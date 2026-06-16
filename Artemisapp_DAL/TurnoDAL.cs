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


        // CRUDO: devuelve todos los nodos <Turno> sin mapear
        public List<XElement> ObtenerTodosCrudos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("Turno").ToList();
        }

        // CRUDO: devuelve los nodos de los turnos de un DNI
        public List<XElement> BuscarPorDNICrudo(string dni)
        {
            InicializarXML();
            List<XElement> lista = new List<XElement>();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elem in doc.Root.Elements("Turno"))
            {
                if ((string)elem.Element("Dni") == dni)
                    lista.Add(elem);
            }
            return lista;
        }

        // CRUDO: recibe un nodo ya armado y lo guarda
        public bool GuardarCrudo(XElement nuevoTurno)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoTurno);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: reemplaza el nodo existente (busca por IdTurno) por el nuevo
        public bool ActualizarCrudo(XElement turnoActualizado)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                string id = (string)turnoActualizado.Element("IdTurno");

                XElement elem = doc.Root.Elements("Turno")
                                  .FirstOrDefault(x => (string)x.Element("IdTurno") == id);
                if (elem != null)
                {
                    elem.ReplaceWith(turnoActualizado);
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: cancela un turno por ID (solo cambia el Estado)
        public bool CancelarCrudo(string idTurno)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                XElement elem = doc.Root.Elements("Turno")
                                  .FirstOrDefault(x => (string)x.Element("IdTurno") == idTurno);
                if (elem != null)
                {
                    elem.Element("Estado").Value = "Cancelado";
                    doc.Save(ruta);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
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