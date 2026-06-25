using Artemisapp_BE;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string password = txtPassword.Text;

                UsuarioClaveBLL bll = new UsuarioClaveBLL();
                bool ingreso = bll.IniciarSesion(usuario, password);

                if (ingreso)
                {
                    // Traemos el usuario completo (con sus roles cargados)
                    UsuarioClaves usuarioLogueado = bll.ObtenerPorNombreUsuario(usuario);


                    // Abrimos el menú principal pasándole el usuario logueado
                    FormMenuInicio menu = new FormMenuInicio(usuarioLogueado);
                    menu.Show();

                    // Ocultamos el login (no lo cerramos, para no cerrar toda la app)
                    this.Hide();
                }
                else
                {
                    lblResultado.Text = "Usuario o contraseña incorrectos.";
                }
            }
            catch (Exception ex)
            {
                //lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
