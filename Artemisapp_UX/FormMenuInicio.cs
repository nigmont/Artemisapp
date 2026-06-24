using Artemisapp_BE;
using Artemisapp_BE.Composite;
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
    public partial class FormMenuInicio : Form
    {
        private UsuarioClaves _usuario; // el usuario logueado

        public FormMenuInicio(UsuarioClaves usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FormMenuInicio_Load(object sender, EventArgs e)
        {
            // Recorremos cada opción del menú de arriba
            foreach (ToolStripMenuItem opcion in menuStrip1.Items)
            {
                // Si la opción no tiene Tag (como "Inicio"), la dejamos visible siempre
                if (opcion.Tag == null || opcion.Tag.ToString() == "")
                    continue;

                string permisoNecesario = opcion.Tag.ToString();

                // Por defecto, ocultamos la opción
                opcion.Visible = false;

                // Recorremos los roles del usuario y sus permisos
                foreach (BERol rol in _usuario.Roles)
                {
                    foreach (BEComposite permiso in rol.ObtenerHijos())
                    {
                        // Si encontramos un permiso con ese nombre, mostramos la opción
                        if (permiso.Nombre == permisoNecesario)
                        {
                            opcion.Visible = true;
                        }
                    }
                }
            }
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionAccesos form = new FormGestionAccesos(); // Crear una instancia del formulario
            form.Show(); // Mostrar el formulario
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void manuCambiarUsuario_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Reinicia la aplicación para volver a la pantalla de login
        }
    }
}
