using Artemisapp_BE.Animales;
using Artemisapp_BLL;
using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormAgregarMascota : Form
    {
        // Propiedad pública: acá queda la mascota creada para que Clientes la lea
        public Animal MascotaCreada { get; private set; }
        
        private string _nroCte;

        public FormAgregarMascota(string nroCte)
        {
            InitializeComponent();
            _nroCte = nroCte;
            lblNroClienteMascota.Text = "Cliente N°: " + nroCte;
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
            try
            {
                // Tomamos los datos de la mascota
                string tipo = cmbTipoAnimal.SelectedItem?.ToString();
                string nombre = txtNombreMascota.Text.Trim();
                string raza = txtRaza.Text.Trim();

                // Validaciones mínimas
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

                int edad = int.Parse(txtEdad.Text.Trim());
                double peso = double.Parse(txtPeso.Text.Trim());

                bool castrado = chkCastrado.Checked;
                bool vacunado = chkVacunado.Checked;
                bool medicado = chkMedicado.Checked;

                // Creamos el Perro o Gato según el combo
                Animal mascota;
                if (tipo == "Perro")
                    mascota = new Perro(nombre, edad, peso, raza, _nroCte, castrado, vacunado, medicado);
                else
                    mascota = new Gato(nombre, edad, peso, raza, _nroCte, castrado, vacunado, medicado);

                // Guardamos la mascota (queda vinculada al cliente por el NroCte)
                AnimalBLL bll = new AnimalBLL();
                bll.RegistrarAnimal(mascota);

                MessageBox.Show("Mascota guardada y asociada al cliente N° " + _nroCte);
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



        private void button3_Click(object sender, EventArgs e)   // Aceptar
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)   // Cancelar
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
