using Artemisapp_BE.Animales;
using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormAgregarMascota : Form
    {
        // Propiedad pública: acá queda la mascota creada para que Clientes la lea
        public Animal MascotaCreada { get; private set; }

        public FormAgregarMascota()
        {
            InitializeComponent();
        }

        private void FormAgregarMascota_Load(object sender, EventArgs e)
        {
            // Cargar las opciones del combo de especie
            cmbTipoAnimal.Items.Clear();
            cmbTipoAnimal.Items.Add("Perro");
            cmbTipoAnimal.Items.Add("Gato");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // --- Validaciones básicas ---
            if (cmbTipoAnimal.SelectedItem == null)
            {
                MessageBox.Show("Elegí si es perro o gato.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreMascota.Text))
            {
                MessageBox.Show("Ingresá el nombre de la mascota.");
                return;
            }

            // --- Leer los campos comunes (con conversión segura) ---
            string nombre = txtNombreMascota.Text;

            int edad = 0;
            int.TryParse(txtEdad.Text, out edad);

            double peso = 0;
            double.TryParse(txtPeso.Text, out peso);

            string raza = txtRaza.Text;

            // El NroCte (propietario) lo asigna Clientes después, va vacío por ahora
            string nroCte = "";

            // --- Armar Perro o Gato según el combo ---
            string tipo = cmbTipoAnimal.SelectedItem.ToString();

            if (tipo == "Perro")
            {
                MascotaCreada = new Perro(nombre, edad, peso, raza, nroCte,
                    chkCastrado.Checked, chkVacunado.Checked, chkMedicado.Checked);
            }
            else // Gato
            {
                MascotaCreada = new Gato(nombre, edad, peso, raza, nroCte,
                    chkCastrado.Checked, chkVacunado.Checked, chkMedicado.Checked);
            }

            // Cerrar el form devolviendo OK
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        private void button3_Click(object sender, EventArgs e)   // Aceptar
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)   // Cancelar
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
