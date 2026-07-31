using Artemisapp_BE;
using Artemisapp_BE.Animales;
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
        private double _montoConsulta = 10000;

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
                string dni = txtDni.Text.Trim();

                if (dni == "")
                {
                    lblResultado.Text = "Ingresá un DNI para buscar.";
                    return;
                }

                // 1. Buscamos el cliente por DNI para obtener su NroCte
                ClienteBLL clienteBLL = new ClienteBLL();
                Cliente cli = clienteBLL.BuscarClientePorDNI(dni);

                if (cli != null)
                {
                    txtNumeroCliente.Text = cli.NroCte;

                    // Se carga el combo con TODAS las mascotas del cliente
                    AnimalBLL animalBLLmascota = new AnimalBLL();
                    List<Animal> mascotasCli = animalBLLmascota.ObtenerAnimalesPorDNI(cli.NroCte);

                    cmbMascotas.Items.Clear();
                    foreach (Animal m in mascotasCli)
                    {
                        cmbMascotas.Items.Add(m.Nombre);
                    }

                    if (cmbMascotas.Items.Count > 0)
                    {
                        cmbMascotas.SelectedIndex = 0; // por defecto selecciona la primera, pero el veterinario puede cambiarla
                        lblNombreMascota1.Text = cmbMascotas.SelectedItem.ToString();
                    }
                    else
                    {
                        lblNombreMascota1.Text = "Sin mascotas";
                    }

                    // Buscamos si el cliente tiene un turno pendiente para hoy
                    TurnosBLL turnosBLL = new TurnosBLL();
                    Turno turnoPendiente = turnosBLL.BuscarTurnoPendienteDeHoy(dni);

                    if (turnoPendiente != null)
                    {
                        lblNumeroTurno.Text = "N° " + turnoPendiente.IdTurno;
                        lblEstadoTurno.Text = "Estado: " + turnoPendiente.Estado + " — " + turnoPendiente.Horario + " hs";
                        lblNumeroTurno.Tag = turnoPendiente; // guardamos el turno completo para usarlo después
                        btnFinalizarTurno.Enabled = true;
                    }
                    else
                    {
                        lblNumeroTurno.Text = "N° —";
                        lblEstadoTurno.Text = "Sin turno pendiente para hoy";
                        lblNumeroTurno.Tag = null;
                        btnFinalizarTurno.Enabled = false;
                    }
                }
                else
                {
                    txtNumeroCliente.Text = "";
                    lblNombreMascota1.Text = "";
                }

                // 2. Mostramos TODAS las mascotas de la clínica en la grilla
                AnimalBLL animalBLL = new AnimalBLL();
                dtgvListadoMascotas.DataSource = null;
                dtgvListadoMascotas.DataSource = animalBLL.ObtenerTodos();

                // 3. Buscamos la historia clínica existente por DNI
                Artemisapp_BE.HistoriaClinica h = bll.BuscarHistoriaPorDNI(dni);

                if (h != null)
                {
                    // Si ya tiene historia, la cargamos
                    txtIdHistoria.Text = h.IdHistoria;
                    dtpFecha.Value = h.FechaDeConsulta;
                    txtEstudios.Text = h.Estudios;
                    txtInternaciones.Text = h.Internaciones;
                    txtObservaciones.Text = h.Observaciones;
                    lblResultado.Text = "✅ Historia encontrada:" +
                                        "\nDNI: " + h.Dni +
                                        "\nID Historia: " + h.IdHistoria +
                                        "\nMascota: " + h.NombreMascota +
                                        "\nFecha: " + h.FechaDeConsulta.ToString("dd/MM/yyyy") +
                                        "\nEstudios: " + h.Estudios +
                                        "\nInternaciones: " + h.Internaciones +
                                        "\nObservaciones: " + h.Observaciones +
                                        "\nMonto: $" + h.MontoConsulta;
                }
                else
                {
                    // Si no tiene historia, generamos un Id nuevo automático (arranca en 100100)
                    int nuevoId = 100100;
                    foreach (Artemisapp_BE.HistoriaClinica hist in bll.ObtenerTodas())
                    {
                        int idExistente;
                        if (int.TryParse(hist.IdHistoria, out idExistente) && idExistente >= nuevoId)
                            nuevoId = idExistente + 1;
                    }
                    txtIdHistoria.Text = nuevoId.ToString();
                    lblResultado.Text = "Cliente sin historia previa. Se generó el ID: " + nuevoId;
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
                string dni = txtDni.Text.Trim();
                string nroCte = txtNumeroCliente.Text.Trim();

                if (dni == "" || nroCte == "")
                {
                    lblResultado.Text = "Primero buscá un cliente por DNI.";
                    return;
                }

                // Validamos que se haya elegido una mascota en el combo
                if (cmbMascotas.SelectedItem == null)
                {
                    lblResultado.Text = "Seleccioná una mascota del desplegable.";
                    return;
                }

                string nombreMascota = cmbMascotas.SelectedItem.ToString();

                double montoConsulta = _montoConsulta;

                Artemisapp_BE.HistoriaClinica h = new Artemisapp_BE.HistoriaClinica(
                    dni,
                    txtIdHistoria.Text,
                    nombreMascota,
                    dtpFecha.Value,
                    txtEstudios.Text,
                    txtInternaciones.Text,
                    txtObservaciones.Text,
                    montoConsulta
                );

                bool resultado = bll.RegistrarConsulta(h);

                if (resultado)
                {
                    lblResultado.Text = "Historia clínica guardada:" +
                                        "\nDNI: " + dni +
                                        "\nID Historia: " + txtIdHistoria.Text +
                                        "\nMascota: " + nombreMascota +
                                        "\nFecha: " + dtpFecha.Value.ToString("dd/MM/yyyy") +
                                        "\nEstudios: " + txtEstudios.Text +
                                        "\nInternaciones: " + txtInternaciones.Text +
                                        "\nObservaciones: " + txtObservaciones.Text +
                                        "\nMonto: $" + montoConsulta;
                    MessageBox.Show("📝🩺 Consulta finalizada.\nGracias por usar el servicio!🐱 ");
                }
                else
                    lblResultado.Text = "No se pudo guardar la historia clínica.";
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
            try
            {
                // Base fija de la consulta
                _montoConsulta = 10000;

                // Sumamos los adicionales seleccionados en el ListBox
                foreach (var item in clbAdicionales.SelectedItems)
                {
                    string texto = item.ToString();
                    if (texto.Contains("Limpieza Dental"))
                        _montoConsulta += 45000;
                    else if (texto.Contains("Vacunación"))
                        _montoConsulta += 20000;
                    else if (texto.Contains("Medicación"))
                        _montoConsulta += 5000;
                    else if (texto.Contains("Desparacitación"))
                        _montoConsulta += 10000;
                    else if (texto.Contains("Ecografía"))
                        _montoConsulta += 25000;
                    else if (texto.Contains("Castración"))
                        _montoConsulta += 90000;
                }

                // Se suma el otro monto si el veterinario cargó algo
                if (txtOtroMonto.Text.Trim() != "")
                {
                    double otro;
                    if (double.TryParse(txtOtroMonto.Text.Trim(), out otro))
                        _montoConsulta += otro;
                }

                // Se muestra el total en el label
                lblMontoParcialConsulta.Text = "Monto consulta: $" + _montoConsulta;
                MessageBox.Show("Total consulta: $" + _montoConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el monto: " + ex.Message);
            }
        }





        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void clbAdicionales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMascotas.SelectedItem == null) return;

            string dni = txtDni.Text.Trim();
            string mascotaElegida = cmbMascotas.SelectedItem.ToString();

            lblNombreMascota1.Text = mascotaElegida;

            // Buscamos si YA existe una historia clínica de esta mascota puntual
            Artemisapp_BE.HistoriaClinica h = bll.BuscarHistoriaPorDNIyMascota(dni, mascotaElegida);

            if (h != null)
            {
                // Ya tiene historia esta mascota: cargamos sus datos
                txtIdHistoria.Text = h.IdHistoria;
                dtpFecha.Value = h.FechaDeConsulta;
                txtEstudios.Text = h.Estudios;
                txtInternaciones.Text = h.Internaciones;
                txtObservaciones.Text = h.Observaciones;
                lblResultado.Text = "✅ Historia encontrada:" +
                                    "\nDNI: " + h.Dni +
                                    "\nID Historia: " + h.IdHistoria +
                                    "\nMascota: " + h.NombreMascota +
                                    "\nFecha: " + h.FechaDeConsulta.ToString("dd/MM/yyyy") +
                                    "\nEstudios: " + h.Estudios +
                                    "\nInternaciones: " + h.Internaciones +
                                    "\nObservaciones: " + h.Observaciones +
                                    "\nMonto: $" + h.MontoConsulta;
            }
            else
            {
                // Esta mascota no tiene historia previa: limpiamos y generamos un ID nuevo
                txtEstudios.Clear();
                txtInternaciones.Clear();
                txtObservaciones.Clear();
                dtpFecha.Value = DateTime.Now;

                int nuevoId = 100100;
                foreach (Artemisapp_BE.HistoriaClinica hist in bll.ObtenerTodas())
                {
                    int idExistente;
                    if (int.TryParse(hist.IdHistoria, out idExistente) && idExistente >= nuevoId)
                        nuevoId = idExistente + 1;
                }
                txtIdHistoria.Text = nuevoId.ToString();
                lblResultado.Text = mascotaElegida + " no tiene historia previa. Se generó el ID: " + nuevoId;
            }

            // Reordenamos la grilla para que esta mascota quede primera (lo que armamos antes)
            AnimalBLL animalBLL = new AnimalBLL();
            List<Animal> todasLasMascotas = animalBLL.ObtenerTodos();
            List<Animal> ordenadas = todasLasMascotas
                .OrderBy(a => (a.Nombre == mascotaElegida && a.NroCte == txtNumeroCliente.Text.Trim()) ? 0 : 1)
                .ToList();

            dtgvListadoMascotas.DataSource = null;
            dtgvListadoMascotas.DataSource = ordenadas;
        }

        private void btnModificarConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarTurnoo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(lblNumeroTurno.Tag is Turno turno))
                {
                    MessageBox.Show("No hay un turno pendiente para marcar como atendido.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Marcar el turno N° " + turno.IdTurno + " como Atendido?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;

                turno.Estado = "Atendido";
                TurnosBLL turnosBLL = new TurnosBLL();
                bool ok = turnosBLL.ModificarTurno(turno);

                if (ok)
                {
                    lblEstadoTurno.Text = "Estado: Atendido ✔";
                    lblNumeroTurno.Tag = null; // ya se procesó, evita marcarlo dos veces
                    btnFinalizarTurno.Enabled = false;
                    MessageBox.Show("Turno marcado como Atendido.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el turno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
