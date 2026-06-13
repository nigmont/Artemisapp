using Artemisapp_BE.Personas;
using Artemisapp_BLL;
using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class FormPruebaPersona : Form
    {
        PersonaBLL bll = new PersonaBLL();

        public FormPruebaPersona()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDNI.Text,
                    txtTelefono.Text,
                    txtCorreo.Text
                );

                bool resultado = bll.RegistrarUsuario(p);

                if (resultado)
                    lblResultado.Text = "✅ Persona guardada correctamente.";
                else
                    lblResultado.Text = "❌ No se pudo guardar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "❌ Error: " + ex.Message;
            }
        }




        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Persona p = bll.BuscarUsuarioPorDNI(txtDNI.Text);

                if (p != null)
                {
                    txtNombre.Text = p.Nombre;
                    txtApellido.Text = p.Apellido;
                    txtTelefono.Text = p.Telefono;
                    txtCorreo.Text = p.Correo;
                    lblResultado.Text = "✅ Persona encontrada.";
                }
                else
                {
                    lblResultado.Text = "❌ No se encontró ninguna persona con ese DNI.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "❌ Error: " + ex.Message;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool resultado = bll.EliminarUsuario(txtDNI.Text);

                if (resultado)
                {
                    lblResultado.Text = "✅ Persona eliminada correctamente.";
                    txtDNI.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                }
                else
                    lblResultado.Text = "❌ No se encontró ninguna persona con ese DNI.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "❌ Error: " + ex.Message;
            }
        }
    }
}
