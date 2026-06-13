using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormPruebaTurno : Form
    {
        TurnosBLL bll = new TurnosBLL();

        public FormPruebaTurno()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Turno t = new Turno(
                    txtIdTurno.Text,
                    txtDNI.Text,
                    txtEstado.Text,
                    dtpFecha.Value,
                    txtHorario.Text,
                    txtMotivo.Text
                );

                bool resultado = bll.RegistrarTurnoInmediato(t);

                if (resultado)
                    lblResultado.Text = "Turno guardado correctamente.";
                else
                    lblResultado.Text = "No se pudo guardar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Turno> turnos = bll.ObtenerTurnosPorDNI(txtDNI.Text);

                if (turnos != null && turnos.Count > 0)
                {
                    lblResultado.Text = "✅ Turnos encontrados para DNI " + txtDNI.Text + ":\n";

                    foreach (Turno t in turnos)
                    {
                        lblResultado.Text += "\nID: " + t.IdTurno +
                                            " \n| Estado: " + t.Estado +
                                            " \n| Fecha: " + t.Fecha.ToString("dd/MM/yyyy") +
                                            " \n| Horario: " + t.Horario +
                                            " \n| Motivo: " + t.Motivo;
                    }
                }
                else
                {
                    lblResultado.Text = "No se encontraron turnos para ese DNI.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnVerificarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                bool disponible = bll.VerificarDisponibilidad(
                    txtDNI.Text,
                    dtpFecha.Value,
                    txtHorario.Text
                );

                if (disponible)
                    lblResultado.Text = "Horario disponible para ese DNI.";
                else
                    lblResultado.Text = "El horario ya está ocupado para ese DNI.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = bll.CancelarTurno(txtIdTurno.Text);

                if (resultado)
                    lblResultado.Text = "Turno cancelado correctamente.";
                else
                    lblResultado.Text = "No se encontró ningún turno con ese ID.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }
    }
}