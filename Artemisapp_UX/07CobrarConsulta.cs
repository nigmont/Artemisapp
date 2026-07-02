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
            ConfigurarGrilla();
            CargarProductos();

            // Cargar la consulta que vino de historia clínica (si vino)
            if (consultaRecibida != null)
            {
                dtgvItemsCobrar.Rows.Add(
                    "CONSULTA",
                    consultaRecibida.NombreProducto,
                    consultaRecibida.Cantidad,
                    consultaRecibida.PrecioUnitario,
                    consultaRecibida.Monto
                );
            }

            RecalcularTotales();
        }

        private void ConfigurarGrilla()
        {
            dtgvItemsCobrar.Columns.Clear();
            dtgvItemsCobrar.Columns.Add("colIdProducto", "IdProducto");
            dtgvItemsCobrar.Columns.Add("colConcepto", "Concepto");
            dtgvItemsCobrar.Columns.Add("colCantidad", "Cant");
            dtgvItemsCobrar.Columns.Add("colPrecioUnit", "Precio Unit.");
            dtgvItemsCobrar.Columns.Add("colSubtotal", "Subtotal");

            // La columna de IdProducto la usamos internamente, no hace falta mostrarla
            dtgvItemsCobrar.Columns["colIdProducto"].Visible = false;

            // Que el usuario no edite las celdas a mano
            dtgvItemsCobrar.AllowUserToAddRows = false;
            dtgvItemsCobrar.ReadOnly = true;
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
            int indice = lstbProductos.SelectedIndex;
            if (indice < 0) return;

            Producto p = productosCargados[indice];

            // Control de stock (los "Servicio" no descuentan stock, no aplican avisos)
            if (p.Categoria != "Servicio")
            {
                if (p.Stock == 0)
                {
                    MessageBox.Show("Sin existencias: " + p.Nombre, "Stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (p.Stock >= 1 && p.Stock <= 3)
                {
                    MessageBox.Show("Pocas existencias de " + p.Nombre + " (quedan " + p.Stock + ")",
                        "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Agregar el producto como renglón de la grilla
            dtgvItemsCobrar.Rows.Add(
                p.IdProducto,   // colIdProducto (oculta)
                p.Nombre,       // colConcepto
                1,              // colCantidad
                p.Precio,       // colPrecioUnit
                p.Precio        // colSubtotal
            );

            RecalcularTotales();
        }

        // Suma los renglones, aplica descuento e IVA, y muestra los totales
        private void RecalcularTotales()
        {
            double subtotal = 0;
            foreach (DataGridViewRow fila in dtgvItemsCobrar.Rows)
            {
                if (fila.Cells["colSubtotal"].Value != null)
                    subtotal += Convert.ToDouble(fila.Cells["colSubtotal"].Value);
            }

            // Descuento general (%) tomado del NumericUpDown
            double porcentajeDesc = 0;
            double.TryParse(nudDescuentoGeneral.Text, out porcentajeDesc);
            double montoDescuento = subtotal * porcentajeDesc / 100.0;

            double baseImponible = subtotal - montoDescuento;

            // IVA 21%
            double iva = baseImponible * 0.21;
            double total = baseImponible + iva;

            // Mostrar en los labels
            lblTotalParcial.Text = "Total Parcial: $" + subtotal.ToString("F2");
            lblDescuentos.Text = "Descuentos: $" + montoDescuento.ToString("F2");
            lblIva.Text = "IVA (21%): $" + iva.ToString("F2");
            lblTotalACobrar.Text = "$" + total.ToString("F2");
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
    }
}