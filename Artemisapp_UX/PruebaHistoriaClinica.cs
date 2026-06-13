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
    public partial class PruebaHistoriaClinica : Form
    {
        HistoriaClinicaBLL bll = new HistoriaClinicaBLL();
        // historia clinica : DNI, ID historia, fecha de consulta,
        // estudios realizados, internaciones previas, observaciones médicas

        public PruebaHistoriaClinica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //Guardar
        {
            try
            {
                HistoriaClinica h = new HistoriaClinica(
                    txtDni.Text,
                    txtIdHistoria.Text,
                    dtpFecha.Value,
                    txtEstudios.Text,
                    txtInternaciones.Text,
                    txtObservaciones.Text
                );

                bool resultado = bll.RegistrarConsulta(h);

                if (resultado)
                    lblResultado.Text = "✅ Historia clínica registrada correctamente.";
                else
                    lblResultado.Text = "❌ No se pudo registrar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "❌ Error: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)  //Buscar
        {
            try
            {
                HistoriaClinica h = bll.BuscarHistoriaPorDNI(txtDni.Text);

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
                HistoriaClinica h = new HistoriaClinica(
                    txtDni.Text,
                    txtIdHistoria.Text,
                    dtpFecha.Value,
                    txtEstudios.Text,
                    txtInternaciones.Text,
                    txtObservaciones.Text
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
                    lblResultado.Text = "✅ Alta médica otorgada correctamente.";
                else
                    lblResultado.Text = "❌ No se encontró la historia clínica con ese ID.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "❌ Error: " + ex.Message;
            }
        }
    }
}
