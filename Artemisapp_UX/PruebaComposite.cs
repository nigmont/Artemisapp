using Artemisapp_BE.Composite;
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
    public partial class PruebaComposite : Form
    {
        public PruebaComposite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ── PARTE 1: Guardar permisos y un rol que los contiene ──
            PermisoBLL permisoBLL = new PermisoBLL();
            RolBLL rolBLL = new RolBLL();

            // Creamos dos permisos y los guardamos
            BEPermiso p1 = new BEPermiso(1, "ABM Usuario");
            BEPermiso p2 = new BEPermiso(2, "ABM Producto");
            permisoBLL.RegistrarPermiso(p1);
            permisoBLL.RegistrarPermiso(p2);

            // Creamos un rol, le metemos los permisos, y lo guardamos
            BERol rolGerente = new BERol(100, "Gerente");
            rolGerente.Agregar(p1);
            rolGerente.Agregar(p2);
            rolBLL.RegistrarRol(rolGerente);

            // ── PARTE 2: Leer el rol DESDE el XML y mostrar sus permisos ──
            BERol rolLeido = rolBLL.BuscarPorId(100);

            string txt = "Rol leído del XML: " + rolLeido.Nombre + "\n";
            txt += "Permisos que contiene:\n";
            foreach (BEComposite hijo in rolLeido.ObtenerHijos())
            {
                txt += " - " + hijo.Nombre + "\n";
            }

            MessageBox.Show(txt);
        }
    }
}
