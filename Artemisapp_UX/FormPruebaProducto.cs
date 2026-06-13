using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormPruebaProducto : Form
    {
        ProductoBLL bll = new ProductoBLL();

        public FormPruebaProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto(
                    txtId.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtCategoria.Text,
                    dtpVencimiento.Value,
                    double.Parse(txtPrecio.Text, CultureInfo.InvariantCulture),
                    txtProveedor.Text,
                    int.Parse(txtStock.Text)
                );

                bool resultado = bll.RegistrarProducto(p);

                if (resultado)
                    lblResultado.Text = "Producto guardado correctamente.";
                else
                    lblResultado.Text = "No se pudo guardar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = bll.EliminarProducto(txtId.Text);

                if (resultado)
                {
                    lblResultado.Text = "Producto eliminado correctamente.";
                    txtId.Clear();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtCategoria.Clear();
                    txtPrecio.Clear();
                    txtProveedor.Clear();
                    txtStock.Clear();
                }
                else
                    lblResultado.Text = "No se encontró ningún producto con ese ID.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = bll.BuscarProductoPorId(txtId.Text);

                if (p != null)
                {
                    txtNombre.Text = p.Nombre;
                    txtDescripcion.Text = p.Descripcion;
                    txtCategoria.Text = p.Categoria;
                    dtpVencimiento.Value = p.FechaDeVencimiento;
                    txtPrecio.Text = p.Precio.ToString(CultureInfo.InvariantCulture);
                    txtProveedor.Text = p.Proveedor;
                    txtStock.Text = p.Stock.ToString();
                    lblResultado.Text = "✅ Encontrado: " + p.Nombre +
                    " \n| Descripción: " + p.Descripcion +
                    " \n| Categoría: " + p.Categoria +
                    " \n| Vencimiento: " + p.FechaDeVencimiento.ToString("dd/MM/yyyy") +
                    " \n| Precio: $" + p.Precio.ToString(CultureInfo.InvariantCulture) +
                    " \n| Proveedor: " + p.Proveedor +
                    " \n| Stock: " + p.Stock;
                }
                else
                {
                    lblResultado.Text = "No se encontró ningún producto con ese ID.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }
    }   
}
