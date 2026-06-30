using Artemisapp_BE;
using Artemisapp_BE.Personas;
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
    public partial class _05Turnos : Form
    {
        public _05Turnos()
        {
            InitializeComponent();
        }

        private void btnBuscarClienteTurno_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniTurno.Text.Trim();

                if (dni == "")
                {
                    MessageBox.Show("Ingresá un DNI para buscar.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();
                Cliente c = bll.BuscarClientePorDNI(dni);

                if (c != null)
                {
                    // Mostramos el nombre completo del cliente encontrado
                    txtClienteTurno.Text = c.Nombre + " " + c.Apellido;
                    txtClienteTurnoCita.Text = c.Nombre + " " + c.Apellido;
                    txtDniCita.Text = c.Dni;
                }
                else
                {
                    txtClienteTurno.Text = "";
                    MessageBox.Show("No se encontró un cliente con ese DNI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDniTurno.Clear();
            txtClienteTurno.Clear();
            
        }

        private void _05Turnos_Load(object sender, EventArgs e)
        {
            CargarProfesionales();
            CargarMotivos();
            CargarHorarios();
        }

        private void CargarProfesionales()
        {
            VeterinarioBLL vetBLL = new VeterinarioBLL();
            List<Veterinario> veterinarios = vetBLL.ObtenerTodos();

            cbProfesional.DataSource = veterinarios;
            cbProfesional.DisplayMember = "NombreCompletoConEspecialidad";
            cbProfesional.SelectedIndex = -1; // que arranque sin nada seleccionado
        }

        // motivos del combobox de motivos de cita
        private void CargarMotivos()
        {
            cbMotivoCita.Items.Clear();
            cbMotivoCita.Items.Add("General");
            cbMotivoCita.Items.Add("Dermatología");
            cbMotivoCita.Items.Add("Castración");
            cbMotivoCita.Items.Add("Vacunación");
            cbMotivoCita.Items.Add("Control");
            cbMotivoCita.Items.Add("Cirugía");
            cbMotivoCita.Items.Add("Alimentación");
        }

        // horarios del combobox de horarios de cita
        private void CargarHorarios()
        {
            cbHorarioCita.Items.Clear();
            cbHorarioCita.Items.Add("08:00");
            cbHorarioCita.Items.Add("08:30");
            cbHorarioCita.Items.Add("09:00");
            cbHorarioCita.Items.Add("09:30");
            cbHorarioCita.Items.Add("10:00");
            cbHorarioCita.Items.Add("10:30");
            cbHorarioCita.Items.Add("11:00");
            cbHorarioCita.Items.Add("11:30");
            cbHorarioCita.Items.Add("12:00");
            cbHorarioCita.Items.Add("12:30");
            cbHorarioCita.Items.Add("13:00");
            cbHorarioCita.Items.Add("13:30");
            cbHorarioCita.Items.Add("14:00");
            cbHorarioCita.Items.Add("14:30");
            cbHorarioCita.Items.Add("15:00");
            cbHorarioCita.Items.Add("15:30");
            cbHorarioCita.Items.Add("16:00");
            cbHorarioCita.Items.Add("16:30");
            cbHorarioCita.Items.Add("17:00");
            cbHorarioCita.Items.Add("17:30");
            cbHorarioCita.Items.Add("18:00");
            cbHorarioCita.Items.Add("18:30");
            cbHorarioCita.Items.Add("19:00");
            cbHorarioCita.Items.Add("19:30");
            cbHorarioCita.Items.Add("20:00");
        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validamos que se haya buscado un cliente
                string dni = txtDniTurno.Text.Trim();
                if (dni == "" || txtClienteTurno.Text.Trim() == "")
                {
                    MessageBox.Show("Primero buscá un cliente por DNI.");
                    return;
                }

                // 2. Validamos que se hayan elegido los datos del turno
                if (cbProfesional.SelectedIndex == -1)
                {
                    MessageBox.Show("Elegí un profesional.");
                    return;
                }
                if (cbMotivoCita.SelectedIndex == -1)
                {
                    MessageBox.Show("Elegí un motivo de consulta.");
                    return;
                }
                if (cbHorarioCita.SelectedIndex == -1)
                {
                    MessageBox.Show("Elegí un horario.");
                    return;
                }

                // 3. Tomamos los datos elegidos
                string motivo = cbMotivoCita.SelectedItem.ToString();
                string horario = cbHorarioCita.SelectedItem.ToString();
                DateTime fecha = dtpFechaCita.Value;

                TurnosBLL bll = new TurnosBLL();

                // 4. Generamos el Nro de turno automático (3 dígitos, arrancando en 101)
                int nuevoNro = 101;
                foreach (Turno t in bll.ObtenerTodos())
                {
                    int nroExistente;
                    if (int.TryParse(t.IdTurno, out nroExistente) && nroExistente >= nuevoNro)
                        nuevoNro = nroExistente + 1;
                }

                // 5. Creamos el turno (estado inicial: Pendiente)
                Turno nuevo = new Turno(
                    nuevoNro.ToString(),
                    dni,
                    "Pendiente",
                    fecha,
                    horario,
                    motivo
                );

                // 6. Lo guardamos
                bll.RegistrarTurnoInmediato(nuevo);

                // 7. Mostramos el Nro generado y avisamos
                txtTurnoCita.Text = nuevoNro.ToString();
                MessageBox.Show("Turno confirmado correctamente. Nro de turno: " + nuevoNro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar el turno: " + ex.Message);
            }
        }

        private void txtClienteTurno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
