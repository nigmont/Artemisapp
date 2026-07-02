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

                    // Mostramos la primera mascota del cliente (la que va a ser atendida)
                    AnimalBLL animalBLLmascota = new AnimalBLL();
                    List<Animal> mascotasCli = animalBLLmascota.ObtenerAnimalesPorDNI(cli.NroCte);
                    if (mascotasCli.Count > 0)
                        lblNombreMascota1.Text = mascotasCli[0].Nombre;
                    else
                        lblNombreMascota1.Text = "Sin mascotas";
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

                // Obtenemos la primera mascota del cliente
                AnimalBLL animalBLL = new AnimalBLL();
                List<Animal> mascotas = animalBLL.ObtenerAnimalesPorDNI(nroCte);

                string nombreMascota;
                if (mascotas.Count > 0)
                    nombreMascota = mascotas[0].Nombre;
                else
                    nombreMascota = "Sin mascota";

                // Monto fijo por ahora
                double montoConsulta = _montoConsulta;

                // Creamos la historia clínica
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

                // Guardamos
                bool resultado = bll.RegistrarConsulta(h);

                if (resultado)
                {
                    // Mostramos los datos de la mascota en el label
                    lblDatosMascota.Text = "Mascota atendida: " + nombreMascota;

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
                    if (texto.Contains("Castración"))
                        _montoConsulta += 90000;
                    else if (texto.Contains("Vacunación"))
                        _montoConsulta += 20000;
                    else if (texto.Contains("Medicación"))
                        _montoConsulta += 5000;
                }

                // Sumamos el otro monto si el veterinario cargó algo
                if (txtOtroMonto.Text.Trim() != "")
                {
                    double otro;
                    if (double.TryParse(txtOtroMonto.Text.Trim(), out otro))
                        _montoConsulta += otro;
                }

                // Mostramos el total en el label
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
    }
}
