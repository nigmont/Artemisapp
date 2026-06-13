using Artemisapp_BE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class HistoriaClinicaDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "HistoriasClinicas.xml");

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            if (!File.Exists(ruta))
            {
                XDocument doc = new XDocument(new XElement("HistoriasClinicas"));
                doc.Save(ruta);
            }
        }

        // GUARDAR una historia clínica nueva
        public bool GuardarHistoria(HistoriaClinica historia)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);

                XElement nuevaHistoria = new XElement("HistoriaClinica",
                    new XElement("Dni", historia.Dni),
                    new XElement("IdHistoria", historia.IdHistoria),
                    new XElement("FechaDeConsulta", historia.FechaDeConsulta.ToString("yyyy-MM-dd")),
                    new XElement("Estudios", historia.Estudios),
                    new XElement("Internaciones", historia.Internaciones),
                    new XElement("Observaciones", historia.Observaciones)
                );

                doc.Root.Add(nuevaHistoria);
                doc.Save(ruta);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // OBTENER TODAS las historias
        public List<HistoriaClinica> ObtenerTodas()
        {
            InicializarXML();
            List<HistoriaClinica> lista = new List<HistoriaClinica>();
            XDocument doc = XDocument.Load(ruta);

            foreach (XElement elem in doc.Root.Elements("HistoriaClinica"))
            {
                HistoriaClinica h = new HistoriaClinica(
                    (string)elem.Element("Dni"),
                    (string)elem.Element("IdHistoria"),
                    DateTime.Parse((string)elem.Element("FechaDeConsulta"), CultureInfo.InvariantCulture),
                    (string)elem.Element("Estudios"),
                    (string)elem.Element("Internaciones"),
                    (string)elem.Element("Observaciones")
                );
                lista.Add(h);
            }
            return lista;
        }

        // BUSCAR historia por DNI
        public HistoriaClinica BuscarPorDNI(string dni)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            XElement elem = doc.Root.Elements("HistoriaClinica").FirstOrDefault(x => (string)x.Element("Dni") == dni);

            if (elem != null)
            {
                return new HistoriaClinica(
                    (string)elem.Element("Dni"),
                    (string)elem.Element("IdHistoria"),
                    DateTime.Parse((string)elem.Element("FechaDeConsulta"), CultureInfo.InvariantCulture),
                    (string)elem.Element("Estudios"),
                    (string)elem.Element("Internaciones"),
                    (string)elem.Element("Observaciones")
                );
            }
            return null;
        }

        // ACTUALIZAR historia clínica
        public bool ActualizarHistoria(HistoriaClinica historia)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement elem = doc.Root.Elements("HistoriaClinica").FirstOrDefault(x => (string)x.Element("IdHistoria") == historia.IdHistoria);

                if (elem != null)
                {
                    elem.Element("FechaDeConsulta").Value = historia.FechaDeConsulta.ToString("yyyy-MM-dd");
                    elem.Element("Estudios").Value = historia.Estudios;
                    elem.Element("Internaciones").Value = historia.Internaciones;
                    elem.Element("Observaciones").Value = historia.Observaciones;
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

        // DAR ALTA MEDICA — cambia internaciones a "Alta"
        public bool DarAltaMedica(string idHistoria)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                XElement elem = doc.Root.Elements("HistoriaClinica").FirstOrDefault(x => (string)x.Element("IdHistoria") == idHistoria);

                if (elem != null)
                {
                    elem.Element("Internaciones").Value = "Alta médica otorgada el " + DateTime.Now.ToString("dd/MM/yyyy");
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
    }
}