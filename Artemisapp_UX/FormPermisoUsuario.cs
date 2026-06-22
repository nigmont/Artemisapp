using Artemisapp_BE.Composite;
using Artemisapp_BE;
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
    public partial class FormPermisoUsuario : Form
    {
        private UsuarioClaves _usuario; // Para mostrar los permisos de este usuario
        public FormPermisoUsuario(UsuarioClaves usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FormPermisoUsuario_Load(object sender, EventArgs e)
        {
            string texto = "Usuario: " + _usuario.Usuario + "\r\n\r\n";

            if (_usuario.Roles.Count == 0)
            {
                texto += "Este usuario no tiene roles asignados.";
            }
            else
            {
                foreach (BERol rol in _usuario.Roles)
                {
                    texto += "ROL: " + rol.Nombre + "\r\n";

                    foreach (BEComposite permiso in rol.ObtenerHijos())
                    {
                        texto += "    - " + permiso.Nombre + "\r\n";
                    }

                    texto += "\r\n";
                }
            }

            txtPermisos.Text = texto;
        }
    }
}
