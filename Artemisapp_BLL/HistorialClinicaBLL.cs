using Artemisapp_BE;
using Artemisapp_DAL;
using System.Collections.Generic;
using Artemisapp_MPP;

namespace Artemisapp_BLL
{
    public class HistoriaClinicaBLL
    {
        HistoriaClinicaDAL dal = new HistoriaClinicaDAL();

        HistoriaClinicaMapper mapper = new HistoriaClinicaMapper();

        public bool RegistrarConsulta(HistoriaClinica historia)
        {
            return mapper.Guardar(historia);
        }

        public bool ActualizarHistoriaClinica(HistoriaClinica historia)
        {
            return mapper.Actualizar(historia);
        }

        public bool RegistrarHospitalizacion(HistoriaClinica historia)
        {
            return mapper.Guardar(historia);
        }

        public bool DarAltaMedica(string idHistoria)
        {
            return mapper.DarAltaMedica(idHistoria);
        }

        public HistoriaClinica BuscarHistoriaPorDNI(string dni)
        {
            return mapper.BuscarPorDNI(dni);
        }

        public List<HistoriaClinica> ObtenerTodas()
        {
            return mapper.ObtenerTodas();
        }
    }
}