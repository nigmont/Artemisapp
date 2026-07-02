using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using Artemisapp_BE;
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class HistoriaClinicaMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public HistoriaClinica ToEntity(XElement elem)
        {
            return new HistoriaClinica(
                (string)elem.Element("Dni"),
                (string)elem.Element("IdHistoria"),
                (string)elem.Element("NombreMascota"),
                DateTime.Parse((string)elem.Element("FechaDeConsulta"), CultureInfo.InvariantCulture),
                (string)elem.Element("Estudios"),
                (string)elem.Element("Internaciones"),
                (string)elem.Element("Observaciones"),
                (double?)elem.Element("MontoConsulta") ?? 0    // si no existe (historias viejas), 0
            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(HistoriaClinica historia)
        {
            return new XElement("HistoriaClinica",
                new XElement("Dni", historia.Dni),
                new XElement("IdHistoria", historia.IdHistoria),
                new XElement("NombreMascota", historia.NombreMascota),
                new XElement("FechaDeConsulta", historia.FechaDeConsulta.ToString("yyyy-MM-dd")),
                new XElement("Estudios", historia.Estudios),
                new XElement("Internaciones", historia.Internaciones),
                new XElement("Observaciones", historia.Observaciones),
                new XElement("MontoConsulta", historia.MontoConsulta)
            );
        }

        public List<HistoriaClinica> ObtenerTodas()
        {
            HistoriaClinicaDAL dal = new HistoriaClinicaDAL();
            List<HistoriaClinica> lista = new List<HistoriaClinica>();

            foreach (XElement elem in dal.ObtenerTodasCrudas())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public HistoriaClinica BuscarPorDNI(string dni)
        {
            HistoriaClinicaDAL dal = new HistoriaClinicaDAL();
            XElement elem = dal.BuscarPorDNICrudo(dni);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(HistoriaClinica historia)
        {
            HistoriaClinicaDAL dal = new HistoriaClinicaDAL();
            XElement nuevaHistoria = ToXml(historia);
            return dal.GuardarCrudo(nuevaHistoria);
        }

        public bool Actualizar(HistoriaClinica historia)
        {
            HistoriaClinicaDAL dal = new HistoriaClinicaDAL();
            XElement historiaActualizada = ToXml(historia);
            return dal.ActualizarCrudo(historiaActualizada);
        }

        public bool DarAltaMedica(string idHistoria)
        {
            HistoriaClinicaDAL dal = new HistoriaClinicaDAL();
            return dal.DarAltaMedica(idHistoria);
        }
    }
}