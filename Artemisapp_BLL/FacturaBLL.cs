using Artemisapp_BE;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class FacturaBLL
    {
        FacturaMapper mapper = new FacturaMapper();
        FacturaDAL dal = new FacturaDAL();

        public bool RegistrarFactura(Factura factura)
        {
            return mapper.Guardar(factura);
        }

        public Factura BuscarPorId(int id)
        {
            return mapper.BuscarPorId(id);
        }

        public List<Factura> ObtenerTodas()
        {
            return mapper.ObtenerTodas();
        }

        // Devuelve el próximo número de factura (correlativo)
        public int ObtenerProximoNumero()
        {
            return dal.ObtenerUltimoId() + 1;
        }
    }
}