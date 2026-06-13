using Artemisapp_BE;
using Artemisapp_DAL;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class HistoriaClinicaBLL
    {
        HistoriaClinicaDAL dal = new HistoriaClinicaDAL();

        public bool RegistrarConsulta(HistoriaClinica historia)
        {
            return dal.GuardarHistoria(historia);
        }

        public bool ActualizarHistoriaClinica(HistoriaClinica historia)
        {
            return dal.ActualizarHistoria(historia);
        }

        public bool RegistrarHospitalizacion(HistoriaClinica historia)
        {
            return dal.GuardarHistoria(historia);
        }

        public bool DarAltaMedica(string idHistoria)
        {
            return dal.DarAltaMedica(idHistoria);
        }

        public HistoriaClinica BuscarHistoriaPorDNI(string dni)
        {
            return dal.BuscarPorDNI(dni);
        }

        public List<HistoriaClinica> ObtenerTodas()
        {
            return dal.ObtenerTodas();
        }
    }
}