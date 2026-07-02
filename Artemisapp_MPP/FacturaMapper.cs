using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using Artemisapp_BE;
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class FacturaMapper
    {
        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Factura factura)
        {
            // Armamos el sub-nodo <Items> con un <Item> por cada renglón
            XElement items = new XElement("Items");
            foreach (Ventas v in factura.Items)
            {
                items.Add(new XElement("Item",
                    new XElement("IdProducto", v.IdProducto),
                    new XElement("NombreProducto", v.NombreProducto),
                    new XElement("Cantidad", v.Cantidad),
                    new XElement("PrecioUnitario", v.PrecioUnitario),
                    new XElement("Monto", v.Monto)
                ));
            }

            return new XElement("Factura",
                new XElement("Id", factura.Id),
                new XElement("Dni", factura.Dni),
                new XElement("Fecha", factura.Fecha.ToString("yyyy-MM-dd HH:mm:ss")),
                new XElement("Subtotal", factura.Subtotal),
                new XElement("DescuentoPorcentaje", factura.DescuentoPorcentaje),
                new XElement("DescuentoMonto", factura.DescuentoMonto),
                new XElement("Iva", factura.Iva),
                new XElement("Total", factura.Total),
                new XElement("MedioDePago", factura.MedioDePago),
                new XElement("Tipo", factura.Tipo),
                items
            );
        }

        // De dato crudo (XML) → entidad de negocio
        public Factura ToEntity(XElement elem)
        {
            // Reconstruir la lista de ítems
            List<Ventas> items = new List<Ventas>();
            XElement nodoItems = elem.Element("Items");
            if (nodoItems != null)
            {
                foreach (XElement item in nodoItems.Elements("Item"))
                {
                    items.Add(new Ventas(
                        0,                                          // Id de renglón: no se usa acá
                        (string)item.Element("IdProducto"),
                        (string)item.Element("NombreProducto"),
                        (int)item.Element("Cantidad"),
                        (double)item.Element("PrecioUnitario"),
                        (string)elem.Element("Dni"),                // dni de la factura
                        DateTime.Parse((string)elem.Element("Fecha"), CultureInfo.InvariantCulture),
                        (double)item.Element("Monto"),
                        (string)elem.Element("MedioDePago"),
                        ""                                          // observaciones
                    ));
                }
            }

            return new Factura(
                (int)elem.Element("Id"),
                (string)elem.Element("Dni"),
                DateTime.Parse((string)elem.Element("Fecha"), CultureInfo.InvariantCulture),
                items,
                (double)elem.Element("Subtotal"),
                (double)elem.Element("DescuentoPorcentaje"),
                (double)elem.Element("DescuentoMonto"),
                (double)elem.Element("Iva"),
                (double)elem.Element("Total"),
                (string)elem.Element("MedioDePago"),
                (string)elem.Element("Tipo")
            );
        }

        public List<Factura> ObtenerTodas()
        {
            FacturaDAL dal = new FacturaDAL();
            List<Factura> lista = new List<Factura>();

            foreach (XElement elem in dal.ObtenerTodasCrudas())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public Factura BuscarPorId(int id)
        {
            FacturaDAL dal = new FacturaDAL();
            XElement elem = dal.BuscarPorIdCrudo(id);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(Factura factura)
        {
            FacturaDAL dal = new FacturaDAL();
            XElement nueva = ToXml(factura);
            return dal.GuardarCrudo(nueva);
        }
    }
}