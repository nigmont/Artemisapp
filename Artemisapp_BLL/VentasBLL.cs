using Artemisapp_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BLL
{
    public class VentasBLL
    {
        public bool RegistrarVenta(Ventas venta) { return false; }

        public bool EmitirComprobante(string dni) { return false; }

        public double CalcularTotalAbonar(string dni) { return 0; }

        public bool RegistrarMedioDePago(string idVenta, string medioPago) { return false; }

        public List<Ventas> ObtenerReporteFacturacion(DateTime fechaDesde, DateTime fechaHasta) { return null; }
    }
}
