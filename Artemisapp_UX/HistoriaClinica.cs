using Artemisapp_BE;
using Artemisapp_BLL;
using com.itextpdf.text.pdf;
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
    public partial class HistoriaClinica : Form
    {
        HistoriaClinicaBLL bll = new HistoriaClinicaBLL();
        // historia clinica : DNI, ID historia, fecha de consulta,
        // estudios realizados, internaciones previas, observaciones médicas

        private Ventas consultaArmada;
        private double montoConsultaCargado = 0;   // lo setea "Agregar Monto"

        public HistoriaClinica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // Guardar
        {
            try
            {
                Artemisapp_BE.HistoriaClinica h = new Artemisapp_BE.HistoriaClinica(
                    txtDni.Text,
                    txtIdHistoria.Text,
                    lblNombreMascota.Text,        // la mascota atendida
                    dtpFecha.Value,
                    txtEstudios.Text,
                    txtInternaciones.Text,
                    txtObservaciones.Text,
                    montoConsultaCargado          // el monto que dejó "Agregar Monto"
                );

                bool resultado = bll.RegistrarConsulta(h);

                if (resultado)
                    lblResultado.Text = "Historia clínica registrada correctamente.";
                else
                    lblResultado.Text = "No se pudo registrar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)  //Buscar
        {
            try
            {
                Artemisapp_BE.HistoriaClinica h = bll.BuscarHistoriaPorDNI(txtDni.Text);

                if (h != null)
                {
                    txtIdHistoria.Text = h.IdHistoria;
                    dtpFecha.Value = h.FechaDeConsulta;
                    txtEstudios.Text = h.Estudios;
                    txtInternaciones.Text = h.Internaciones;
                    txtObservaciones.Text = h.Observaciones;
                    lblResultado.Text = "✅ Historia encontrada:" +
                                        "\nDNI: " + h.Dni +
                                        "\nID Historia: " + h.IdHistoria +
                                        "\nFecha: " + h.FechaDeConsulta.ToString("dd/MM/yyyy") +
                                        "\nEstudios: " + h.Estudios +
                                        "\nInternaciones: " + h.Internaciones +
                                        "\nObservaciones: " + h.Observaciones;
                }
                else
                {
                    lblResultado.Text = "No se encontró historia clínica para ese DNI.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Artemisapp_BE.HistoriaClinica h = new Artemisapp_BE.HistoriaClinica(
                    txtDni.Text,
                    txtIdHistoria.Text,
                    lblNombreMascota.Text,        // NUEVO: la mascota atendida
                    dtpFecha.Value,
                    txtEstudios.Text,
                    txtInternaciones.Text,
                    txtObservaciones.Text,
                    montoConsultaCargado          // NUEVO: el monto cargado
                );

                bool resultado = bll.ActualizarHistoriaClinica(h);

                if (resultado)
                    lblResultado.Text = "Historia clínica actualizada correctamente.";
                else
                    lblResultado.Text = "No se encontró la historia clínica a actualizar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = bll.DarAltaMedica(txtIdHistoria.Text);

                if (resultado)
                    lblResultado.Text = "Alta médica otorgada correctamente.";
                else
                    lblResultado.Text = "No se encontró la historia clínica con ese ID.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtIdHistoria.Clear();
            txtEstudios.Clear();
            txtInternaciones.Clear();
            txtObservaciones.Clear();

            dtpFecha.Value = DateTime.Now;   // el DateTimePicker no tiene Clear()

            lblResultado.Text = "";
        }

        private void PruebaHistoriaClinica_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            double precioBase = 10000;   // precio base de la consulta (hardcodeado)
            double adicionales = 0;

            // Sumar los adicionales seleccionados en el ListBox
            foreach (object item in clbAdicionales.SelectedItems)
            {
                string texto = item.ToString();
                if (texto.Contains("Castración")) adicionales += 90000;
                else if (texto.Contains("Vacunación")) adicionales += 20000;
                // agregá los demás que tengas hardcodeados
            }

            // "Otro" monto libre
            double otro = 0;
            double.TryParse(txtOtroMonto.Text, out otro);

            double totalConsulta = precioBase + adicionales + otro;

            // Mostrar el monto en el label
            lblMontoParcialConsulta.Text = "$" + totalConsulta.ToString("F2");

            // Armar la consulta como Ventas (para pasarla a facturación)
            consultaArmada = new Ventas(
                0,
                "CONSULTA",
                "Consulta veterinaria",
                1,
                totalConsulta,
                txtDni.Text,
                DateTime.Now,
                totalConsulta,
                "",
                ""
            );
            montoConsultaCargado = totalConsulta;
            lblMontoParcialConsulta.Text = "$" + totalConsulta.ToString("F2");
            MessageBox.Show("Monto agregado: $" + totalConsulta.ToString("F2"), "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
