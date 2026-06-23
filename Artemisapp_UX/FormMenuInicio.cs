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

        }
    }
}
