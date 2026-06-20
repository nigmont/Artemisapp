using Artemisapp_BE.Animales;
using Artemisapp_BLL;
using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormPruebaAnimal : Form
    {
        AnimalBLL bll = new AnimalBLL();

        public FormPruebaAnimal()
        {
            InitializeComponent();
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = bll.EliminarAnimal(txtNombre.Text, txtNroCte.Text);

                if (resultado)
                {
                    lblResultado.Text = "Animal eliminado correctamente.";
                    txtNombre.Clear();
                    txtEdad.Clear();
                    txtPeso.Clear();
                    txtRaza.Clear();
                    txtNroCte.Clear();
                }
                else
                    lblResultado.Text = "No se encontró el animal.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Animal a = new Animal(
                    txtNombre.Text,
                    int.Parse(txtEdad.Text),
                    double.Parse(txtPeso.Text),
                    txtRaza.Text,
                    txtNroCte.Text
                );

                bool resultado = bll.RegistrarAnimal(a);

                if (resultado)
                    lblResultado.Text = "Animal guardado correctamente.";
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
                Animal a = bll.BuscarAnimal(txtNombre.Text, txtNroCte.Text);

                if (a != null)
                {
                    txtEdad.Text = a.Edad.ToString();
                    txtPeso.Text = a.Peso.ToString();
                    txtRaza.Text = a.Raza;
                    lblResultado.Text = "Animal encontrado: " + a.Nombre + " | Raza: " + a.Raza + " | Edad: " + a.Edad + " | Peso: " + a.Peso;
                }
                else
                {
                    lblResultado.Text = "No se encontró el animal.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtRaza.Clear();
            txtNroCte.Clear();
        }
    }
}