using System;
using System.Collections.Generic;

namespace Artemisapp_BE
{
    public class Factura
    {
        private int _id;
        private string _dni;                    // cliente al que se factura
        private DateTime _fecha;
        private List<Ventas> _items;            // renglones
        private double _subtotal;
        private double _descuentoPorcentaje;    // lo que teclea el cajero (ej. 10)
        private double _descuentoMonto;         // en pesos ya calculado
        private double _iva;
        private double _total;
        private string _medioDePago;
        private string _tipo;                   // "A", "B", "Consumidor Final"

        public int Id { get { return _id; } set { _id = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public List<Ventas> Items { get { return _items; } set { _items = value; } }
        public double Subtotal { get { return _subtotal; } set { _subtotal = value; } }
        public double DescuentoPorcentaje { get { return _descuentoPorcentaje; } set { _descuentoPorcentaje = value; } }
        public double DescuentoMonto { get { return _descuentoMonto; } set { _descuentoMonto = value; } }
        public double Iva { get { return _iva; } set { _iva = value; } }
        public double Total { get { return _total; } set { _total = value; } }
        public string MedioDePago { get { return _medioDePago; } set { _medioDePago = value; } }
        public string Tipo { get { return _tipo; } set { _tipo = value; } }

        public Factura(int id, string dni, DateTime fecha, List<Ventas> items,
                       double subtotal, double descuentoPorcentaje, double descuentoMonto,
                       double iva, double total, string medioDePago, string tipo)
        {
            _id = id;
            _dni = dni;
            _fecha = fecha;
            _items = items;
            _subtotal = subtotal;
            _descuentoPorcentaje = descuentoPorcentaje;
            _descuentoMonto = descuentoMonto;
            _iva = iva;
            _total = total;
            _medioDePago = medioDePago;
            _tipo = tipo;
        }
    }
}
