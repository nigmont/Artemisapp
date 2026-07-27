using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Artemisapp_UX   // ajustá al namespace real de tu UX
{
    public partial class FormTurnero : Form
    {
        public FormTurnero()
        {
            InitializeComponent();
        }

        private void FormTurnero_Load(object sender, EventArgs e)
        {
            ActualizarTurnero();
        }

        private void timerTurnero_Tick(object sender, EventArgs e)
        {
            ActualizarTurnero();
        }

        private void ActualizarTurnero()
        {
            try
            {
                TurnosBLL bll = new TurnosBLL();
                List<Turno> cola = bll.ObtenerColaDeHoy();

                // Contamos los atendidos de hoy para la estadística de abajo
                int atendidosHoy = bll.ObtenerTodos()
                    .Count(t => t.Fecha.Date == DateTime.Today && t.Estado == "Atendido");

                lblAtendidos.Text = "Atendidos hoy: " + atendidosHoy;
                lblEnEspera.Text = "En espera: " + cola.Count;

                if (cola.Count == 0)
                {
                    lblNumeroTurno.Text = "—";
                    lblHorarioTurno.Text = "--:--";
                    return;
                }

                Turno actual = cola[0];
                lblNumeroTurno.Text = actual.IdTurno;
                lblHorarioTurno.Text = actual.Horario + " hs";
            }
            catch (Exception ex)
            {
                // Si el XML está siendo escrito justo en ese instante, salteamos este refresco
                MessageBox.Show("Turnero: " + ex.Message);
            }
        }
    }
}
