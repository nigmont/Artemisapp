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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Artemisapp_UX
{
    public partial class _07CobrarConsulta : Form
    {
        private Ventas consultaRecibida;             // la consulta que llega de historia clínica
        private List<Producto> productosCargados;    // los productos del almacén, para consultarlos al elegir
        private double montoConsulta = 0;
        private List<Ventas> itemsFactura = new List<Ventas>(); 

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

        private void CargarProductos()
        {
            lstbProductos.Items.Clear();
            ProductoBLL productoBLL = new ProductoBLL();
            productosCargados = productoBLL.ObtenerTodos();

            foreach (Producto p in productosCargados)
                lstbProductos.Items.Add(p.Nombre + " - $" + p.Precio + " (stock: " + p.Stock + ")");
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

        private void btnBuscarNroCte_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtClienteFacturacion.Text.Trim();
                if (dni == "")
                {
                    MessageBox.Show("Ingresá el DNI del cliente.");
                    return;
                }

                ClienteBLL clienteBLL = new ClienteBLL();
                Cliente cli = clienteBLL.BuscarClientePorDNI(dni);
                if (cli == null)
                {
                    MessageBox.Show("No existe un cliente con ese DNI.");
                    return;
                }

                lblClienteNumero.Text = cli.NroCte;

                // Traemos el monto de la consulta desde la historia clínica
                HistoriaClinicaBLL hcBLL = new HistoriaClinicaBLL();

                Artemisapp_BE.HistoriaClinica h = hcBLL.BuscarHistoriaPorDNI(dni);
                montoConsulta = (h != null) ? h.MontoConsulta : 0;
                MessageBox.Show("DNI buscado: '" + dni + "' | Historia encontrada: " + (h != null) + " | Monto: " + (h != null ? h.MontoConsulta.ToString() : "sin historia"));
                itemsFactura.Clear();
                txtTotalParcial.Text = montoConsulta.ToString();
                RecalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstbProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstbProductos.SelectedIndex >= 0 && productosCargados != null)
            {
                Producto p = productosCargados[lstbProductos.SelectedIndex];

                // Lo agregamos como ítem de la factura
                itemsFactura.Add(new Ventas(
                    0,
                    p.IdProducto,
                    p.Nombre,
                    1,                              // cantidad: 1 por selección
                    p.Precio,
                    txtClienteFacturacion.Text.Trim(),
                    DateTime.Now,
                    p.Precio,                       // monto de la línea (precio * 1)
                    "",
                    ""
                ));

                // Lo sumamos al total parcial
                double parcialActual;
                double.TryParse(txtTotalParcial.Text, out parcialActual);
                txtTotalParcial.Text = (parcialActual + p.Precio).ToString();
                RecalcularTotales();
            }
        }

        private void RecalcularTotales()
        {
            double subtotal;
            double.TryParse(txtTotalParcial.Text, out subtotal);

            double iva = subtotal * 0.21;
            txtDescuentoIva.Text = iva.ToString();

            // Descuento 2% solo si paga en efectivo
            double descuento = 0;
            if (rbEfectivo.Checked)
                descuento = (subtotal + iva) * 0.02;
            txtDescuentos.Text = descuento.ToString();

            double total = subtotal + iva - descuento;
            lblTotalACobrar.Text = total.ToString();
            lblMontoPendiente.Text = total.ToString();

            // Vuelto (solo efectivo)
            double efectivo;
            double.TryParse(txtEfectivo.Text, out efectivo);
            if (rbEfectivo.Checked)
                lblVuelto.Text = (efectivo - total).ToString();
            else
                lblVuelto.Text = "0";
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            RecalcularTotales();
        }

        private void _07CobrarConsulta_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnCobrarYFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtClienteFacturacion.Text.Trim();
                if (dni == "" || lblClienteNumero.Text == "")
                {
                    MessageBox.Show("Primero buscá un cliente.");
                    return;
                }

                // Se determina el medio de pago según el radio button
                string medioDePago = "";
                if (rbEfectivo.Checked) medioDePago = "Efectivo";
                else if (rbTransferencia.Checked) medioDePago = "Transferencia";
                else if (rbMercadoPago.Checked) medioDePago = "Mercado Pago";
                else if (rbTarjetaDeCredito.Checked) medioDePago = "Tarjeta de Crédito";
                else
                {
                    MessageBox.Show("Elegí un medio de pago.");
                    return;
                }

                // Agregamos la consulta como un ítem de la factura
                List<Ventas> items = new List<Ventas>(itemsFactura);
                items.Add(new Ventas(0, "CONSULTA", "Consulta veterinaria", 1, montoConsulta, dni, DateTime.Now, montoConsulta, "", ""));

                // Tomamos los valores calculados
                double subtotal, iva, descuentoMonto, total;
                double.TryParse(txtTotalParcial.Text, out subtotal);
                double.TryParse(txtDescuentoIva.Text, out iva);
                double.TryParse(txtDescuentos.Text, out descuentoMonto);
                double.TryParse(lblTotalACobrar.Text, out total);

                double descuentoPorcentaje = rbEfectivo.Checked ? 2 : 0;

                // Tipo de factura: A o B al azar
                Random r = new Random();
                string tipo = (r.Next(0, 2) == 0) ? "A" : "B";

                // Número de factura automático
                FacturaBLL facturaBLL = new FacturaBLL();
                int nuevoId = facturaBLL.ObtenerProximoNumero();

                // Armamos la factura
                Factura factura = new Factura(
                    nuevoId,
                    dni,
                    DateTime.Now,
                    items,
                    subtotal,
                    descuentoPorcentaje,
                    descuentoMonto,
                    iva,
                    total,
                    medioDePago,
                    tipo
                );

                // La guardamos
                facturaBLL.RegistrarFactura(factura);

                MessageBox.Show("Factura N° " + nuevoId + " registrada correctamente.");

                // Generamos el PDF de la factura
                Cliente cliParaPdf = new ClienteBLL().BuscarClientePorDNI(dni);
                GenerarFacturaPDF(factura, cliParaPdf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cobrar: " + ex.Message);
            }
        }

        private void GenerarFacturaPDF(Factura factura, Cliente cli)
        {
            // Carpeta donde se guardan los PDF
            string carpeta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas_PDF");
            if (!System.IO.Directory.Exists(carpeta))
                System.IO.Directory.CreateDirectory(carpeta);

            string rutaPdf = System.IO.Path.Combine(carpeta, "Factura_" + factura.Id + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 40);
            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(rutaPdf, System.IO.FileMode.Create));
            doc.Open();

            // Fuentes
            var fTitulo = iTextSharp.text.FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);
            var fNormal = iTextSharp.text.FontFactory.GetFont("Arial", 10);
            var fBold = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);

            // Encabezado
            doc.Add(new iTextSharp.text.Paragraph("ARTEMISAPP", fTitulo));
            doc.Add(new iTextSharp.text.Paragraph("Factura " + factura.Tipo + "  -  N° " + factura.Id, fBold));
            doc.Add(new iTextSharp.text.Paragraph("Fecha: " + factura.Fecha.ToString("dd/MM/yyyy HH:mm"), fNormal));
            doc.Add(new iTextSharp.text.Paragraph("Vencimiento: " + new DateTime(factura.Fecha.Year, factura.Fecha.Month, DateTime.DaysInMonth(factura.Fecha.Year, factura.Fecha.Month)).ToString("dd/MM/yyyy"), fNormal));
            doc.Add(new iTextSharp.text.Paragraph(" ", fNormal));

            // De:
            doc.Add(new iTextSharp.text.Paragraph("De:", fBold));
            doc.Add(new iTextSharp.text.Paragraph("Artemisapp", fNormal));
            doc.Add(new iTextSharp.text.Paragraph("Domingo Faustino Sarmiento 1173 - 1A, CP 1663", fNormal));
            doc.Add(new iTextSharp.text.Paragraph("Tel: 1133775032", fNormal));
            doc.Add(new iTextSharp.text.Paragraph("Artemisapp_veterinaria@gmail.com", fNormal));
            doc.Add(new iTextSharp.text.Paragraph(" ", fNormal));

            // Para:
            doc.Add(new iTextSharp.text.Paragraph("Para:", fBold));
            if (cli != null)
            {
                doc.Add(new iTextSharp.text.Paragraph(cli.Nombre + " " + cli.Apellido, fNormal));
                doc.Add(new iTextSharp.text.Paragraph("Dirección: " + cli.Direccion, fNormal));
                doc.Add(new iTextSharp.text.Paragraph("Tel: " + cli.Telefono, fNormal));
                doc.Add(new iTextSharp.text.Paragraph("Mail: " + cli.Email, fNormal));
            }
            doc.Add(new iTextSharp.text.Paragraph(" ", fNormal));

            // Tabla de ítems
            iTextSharp.text.pdf.PdfPTable tabla = new iTextSharp.text.pdf.PdfPTable(4);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 4, 1, 2, 2 });

            tabla.AddCell(new iTextSharp.text.Phrase("Descripción", fBold));
            tabla.AddCell(new iTextSharp.text.Phrase("Cant.", fBold));
            tabla.AddCell(new iTextSharp.text.Phrase("Precio Unit.", fBold));
            tabla.AddCell(new iTextSharp.text.Phrase("Importe", fBold));

            foreach (Ventas v in factura.Items)
            {
                tabla.AddCell(new iTextSharp.text.Phrase(v.NombreProducto, fNormal));
                tabla.AddCell(new iTextSharp.text.Phrase(v.Cantidad.ToString(), fNormal));
                tabla.AddCell(new iTextSharp.text.Phrase("$" + v.PrecioUnitario, fNormal));
                tabla.AddCell(new iTextSharp.text.Phrase("$" + v.Monto, fNormal));
            }
            doc.Add(tabla);
            doc.Add(new iTextSharp.text.Paragraph(" ", fNormal));

            // Totales
            doc.Add(new iTextSharp.text.Paragraph("Subtotal: $" + factura.Subtotal, fNormal));
            doc.Add(new iTextSharp.text.Paragraph("Descuento (" + factura.DescuentoPorcentaje + "%): -$" + factura.DescuentoMonto, fNormal));
            doc.Add(new iTextSharp.text.Paragraph("IVA (21%): $" + factura.Iva, fNormal));
            doc.Add(new iTextSharp.text.Paragraph("TOTAL: $" + factura.Total, fTitulo));
            doc.Add(new iTextSharp.text.Paragraph(" ", fNormal));
            doc.Add(new iTextSharp.text.Paragraph("Medio de pago: " + factura.MedioDePago, fNormal));

            doc.Close();

            // Abrimos el PDF automáticamente
            System.Diagnostics.Process.Start(rutaPdf);
        }
    }
}