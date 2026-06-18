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
                    lblResultado.Text = "Bienvenido, ingreso correcto.";
                else
                    lblResultado.Text = "Usuario o contraseña incorrectos.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            UsuarioClaveBLL bll = new UsuarioClaveBLL();

            // Si no hay ningún usuario cargado, creamos uno de prueba
            if (bll.ObtenerTodos().Count == 0)
            {
                UsuarioClaves prueba = new UsuarioClaves(
                    "U001",       // Id
                    "admin",      // Usuario (con esto te logueás)
                    "1234",       // Password
                    "12345678",   // Dni
                    true,         // Activo
                    false         // Bloqueado
                );

                bll.RegistrarUsuario(prueba);
            }
        }
    }
}
