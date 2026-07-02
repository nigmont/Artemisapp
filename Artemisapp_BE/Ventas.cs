using System;

namespace Artemisapp_BE
{
    public class Ventas
    {
        private int _id;
        private string _idProducto;
        private string _nombreProducto;   // para imprimir el renglón
        private int _cantidad;
        private double _precioUnitario;    // precio por unidad
        private string _dni;
        private DateTime _fechaDeVenta;
        private double _monto;             // total de la línea (precioUnitario * cantidad)
        private string _medioDePago;
        private string _observaciones;

        public int Id { get { return _id; } set { _id = value; } }
        public string IdProducto { get { return _idProducto; } set { _idProducto = value; } }
        public string NombreProducto { get { return _nombreProducto; } set { _nombreProducto = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public double PrecioUnitario { get { return _precioUnitario; } set { _precioUnitario = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }
        public DateTime FechaDeVenta { get { return _fechaDeVenta; } set { _fechaDeVenta = value; } }
        public double Monto { get { return _monto; } set { _monto = value; } }
        public string MedioDePago { get { return _medioDePago; } set { _medioDePago = value; } }
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; } }

        public Ventas(int id, string idProducto, string nombreProducto, int cantidad,
                      double precioUnitario, string dni, DateTime fechaDeVenta,
                      double monto, string medioDePago, string observaciones)
        {
            _id = id;
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _cantidad = cantidad;
            _precioUnitario = precioUnitario;
            _dni = dni;
            _fechaDeVenta = fechaDeVenta;
            _monto = monto;
            _medioDePago = medioDePago;
            _observaciones = observaciones;
        }
    }
}

