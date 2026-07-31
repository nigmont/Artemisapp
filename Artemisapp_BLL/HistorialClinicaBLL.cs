                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            using Artemisapp_BE;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System.Collections.Generic;
using System.Linq;

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

        // Busca la última historia clínica de ESA mascota puntual (no solo del cliente)
        public HistoriaClinica BuscarHistoriaPorDNIyMascota(string dni, string nombreMascota)
        {
            return ObtenerTodas()
                .Where(h => h.Dni == dni && h.NombreMascota == nombreMascota)
                .OrderByDescending(h => h.FechaDeConsulta)
                .FirstOrDefault();
        }

        // Devuelve la historia clínica más reciente de ese DNI (la última consulta cerrada)
        public HistoriaClinica BuscarUltimaHistoriaPorDNI(string dni)
        {
            return ObtenerTodas()
                .Where(h => h.Dni == dni)
                .OrderByDescending(h =>
                {
                    int id;
                    return int.TryParse(h.IdHistoria, out id) ? id : 0;
                })
                .FirstOrDefault();
        }
    }
}