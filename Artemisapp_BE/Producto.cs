using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE
{
    public class Producto
    {
        private string _idProducto;
        private string _nombre;
        private string _descripcion;
        private string _categoria;
        private DateTime _fechaDeVencimiento;
        private Double _precio;
        private string _proveedor;
        private int _stock;

        public string IdProducto { get { return _idProducto; } set { _idProducto = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string Categoria { get { return _categoria; } set { _categoria = value; } }
        public DateTime FechaDeVencimiento { get { return _fechaDeVencimiento; } set { _fechaDeVencimiento = value; } }
        public Double Precio { get { return _precio; } set { _precio = value; } }
        public string Proveedor { get { return _proveedor; } set { _proveedor = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }

        public Producto(string idProducto, string nombre, string descripcion, string categoria, DateTime fechaDeVencimiento,
                        Double precio, string proveedor, int stock)
        {
            _idProducto = idProducto;
            _nombre = nombre;
            _descripcion = descripcion;
            _categoria = categoria;
            _fechaDeVencimiento = fechaDeVencimiento;
            _precio = precio;
            _proveedor = proveedor;
            _stock = stock;
        }
    }
}
