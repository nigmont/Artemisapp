using Artemisapp_BE.Animales;
using Artemisapp_BLL;
using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormAgregarMascota : Form
    {
        public Animal MascotaCreada { get; private set; }

        private string _nroCte;
        private bool _esModificacion;
        private Animal _mascotaExistente;

        // Constructor para ALTA (el que ya tenías)
        public FormAgregarMascota(string nroCte)
        {
            InitializeComponent();
            _nroCte = nroCte;
            _esModificacion = false;
            lblNroClienteMascota.Text = "Cliente N°: " + nroCte;
        }

        // Constructor nuevo para MODIFICAR
        public FormAgregarMascota(string nroCte, Animal mascotaExistente)
        {
            InitializeComponent();
            _nroCte = nroCte;
            _esModificacion = true;
            _mascotaExistente = mascotaExistente;
            lblNroClienteMascota.Text = "Cliente N°: " + nroCte;
        }

        private void FormAgregarMascota_Load(object sender, EventArgs e)
        {
            cmbTipoAnimal.Items.Clear();
            cmbTipoAnimal.Items.Add("Perro");
            cmbTipoAnimal.Items.Add("Gato");

            if (_esModificacion)
            {
                // Precargamos los datos de la mascota que se va a editar
                txtNombreMascota.Text = _mascotaExistente.Nombre;
                txtEdad.Text = _mascotaExistente.Edad.ToString();
                txtPeso.Text = _mascotaExistente.Peso.ToString();
                txtRaza.Text = _mascotaExistente.Raza;

                if (_mascotaExistente is Perro perro)
                {
                    cmbTipoAnimal.SelectedItem = "Perro";
                    chkCastrado.Checked = perro.Castrado;
                    chkVacunado.Checked = perro.Vacunado;
                    chkMedicado.Checked = perro.Medicado;
                }
                else if (_mascotaExistente is Gato gato)
                {
                    cmbTipoAnimal.SelectedItem = "Gato";
                    chkCastrado.Checked = gato.Castrado;
                    chkVacunado.Checked = gato.Vacunado;
                    chkMedicado.Checked = gato.Medicado;
                }

                // El nombre es la clave: no se puede editar en modo modificación
                txtNombreMascota.Enabled = false;

                // Cambiamos el texto del botón para que quede claro qué acción va a hacer
                btnGuardarDatos.Text = "Guardar cambios";
            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cmbTipoAnimal.SelectedItem?.ToString();
                string nombre = txtNombreMascota.Text.Trim();
                string raza = txtRaza.Text.Trim();

                if (tipo == null || tipo == "")
                {
                    MessageBox.Show("Elegí si es Perro o Gato.");
                    return;
                }
                if (nombre == "")
                {
                    MessageBox.Show("Ingresá el nombre de la mascota.");
                    return;
                }

                int edad;
                double peso;
                if (!int.TryParse(txtEdad.Text.Trim(), out edad) || edad < 0)
                {
                    MessageBox.Show("Ingresá una edad válida.");
                    return;
                }
                if (!double.TryParse(txtPeso.Text.Trim(), out peso) || peso < 0)
                {
                    MessageBox.Show("Ingresá un peso válido.");
                    return;
                }

                bool castrado = chkCastrado.Checked;
                bool vacunado = chkVacunado.Checked;
                bool medicado = chkMedicado.Checked;

                Animal mascota;
                if (tipo == "Perro")
                    mascota = new Perro(nombre, edad, peso, raza, _nroCte, castrado, vacunado, medicado);
                else
                    mascota = new Gato(nombre, edad, peso, raza, _nroCte, castrado, vacunado, medicado);

                AnimalBLL bll = new AnimalBLL();
                bool ok;

                if (_esModificacion)
                {
                    ok = bll.ActualizarAnimal(mascota);
                    if (ok)
                        MessageBox.Show("Mascota modificada correctamente.");
                    else
                        MessageBox.Show("No se pudo modificar la mascota.");
                }
                else
                {
                    ok = bll.RegistrarAnimal(mascota);
                    if (ok)
                        MessageBox.Show("Mascota guardada y asociada al cliente N° " + _nroCte);
                    else
                        MessageBox.Show("No se pudo guardar la mascota.");
                }

                if (ok)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la mascota: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
