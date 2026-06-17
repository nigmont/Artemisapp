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

        // CRUDO: devuelve todos los nodos <HistoriaClinica> sin mapear
        public List<XElement> ObtenerTodasCrudas()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("HistoriaClinica").ToList();
        }

        // CRUDO: devuelve el nodo de una historia por DNI
        public XElement BuscarPorDNICrudo(string dni)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("HistoriaClinica")
                      .FirstOrDefault(x => (string)x.Element("Dni") == dni);
        }

        // CRUDO: recibe un nodo ya armado y lo guarda
        public bool GuardarCrudo(XElement nuevaHistoria)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevaHistoria);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: reemplaza el nodo existente (busca por IdHistoria) por el nuevo
        public bool ActualizarCrudo(XElement historiaActualizada)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                string id = (string)historiaActualizada.Element("IdHistoria");

                XElement elem = doc.Root.Elements("HistoriaClinica")
                                  .FirstOrDefault(x => (string)x.Element("IdHistoria") == id);
                if (elem != null)
                {
                    elem.ReplaceWith(historiaActualizada);
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