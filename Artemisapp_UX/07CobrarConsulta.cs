using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class _07CobrarConsulta : Form
    {
        private Ventas consultaRecibida;             // la consulta que llega de historia clínica
        private List<Producto> productosCargados;    // los productos del almacén, para consultarlos al elegir

        public _07CobrarConsulta()
        {
            InitializeComponent();
        }

        // Constructor que recibe la consulta desde historia clínica
        public _07CobrarConsulta(Ventas consulta)
        {
            InitializeComponent();
            consultaRecibida = consulta;
        }

        private void _07CobrarConsulta_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfigurarGrilla()
        {
            
        }

        private void CargarProductos()
        {
            lstbProductos.Items.Clear();
            ProductoBLL productoBLL = new ProductoBLL();
            productosCargados = productoBLL.ObtenerTodos();

            foreach (Producto p in productosCargados)
                lstbProductos.Items.Add(p.Nombre + " - $" + p.Precio + " (stock: " + p.Stock + ")");
        }

        private void lstbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Suma los renglones, aplica descuento e IVA, y muestra los totales
        private void RecalcularTotales()
        {
            
        }

        // Recalcular cuando cambia el descuento
        private void nudDescuentoGeneral_ValueChanged(object sender, EventArgs e)
        {
            RecalcularTotales();
        }

        private void nudDescuentoGeneral_TextChanged(object sender, EventArgs e)
        {
            RecalcularTotales();
        }

        private void btnCobrarYFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}