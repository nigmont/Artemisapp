using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormPruebaCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();

        public FormPruebaCliente()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente(
                    txtDNI.Text,
                    txtNroCte.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    new System.Collections.Generic.List<Artemisapp_BE.Animales.Animal>()
                );

                bool resultado = bll.RegistrarCliente(c);

                if (resultado)
                    lblResultado.Text = "Cliente guardado correctamente.";
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
                Cliente c = bll.BuscarClientePorDNI(txtDNI.Text);

                if (c != null)
                {
                    txtNroCte.Text = c.NroCte;
                    txtNombre.Text = c.Nombre;
                    txtApellido.Text = c.Apellido;
                    txtDireccion.Text = c.Direccion;
                    txtTelefono.Text = c.Telefono;
                    txtEmail.Text = c.Email;
                    lblResultado.Text = "Cliente encontrado: " + c.Nombre + " " + c.Apellido;
                }
                else
                {
                    lblResultado.Text = "No se encontró ningún cliente con ese DNI.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool resultado = bll.eliminarCliente(txtDNI.Text);

                if (resultado)
                {
                    lblResultado.Text = "Cliente eliminado correctamente.";
                    txtDNI.Clear();
                    txtNroCte.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                }
                else
                    lblResultado.Text = "No se encontró ningún cliente con ese DNI.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void FormPruebaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
