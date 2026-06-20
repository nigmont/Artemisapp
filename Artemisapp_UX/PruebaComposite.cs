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
    public partial class PruebaComposite : Form
    {
        public PruebaComposite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Permisos simples (hojas)
            BEPermiso p1 = new BEPermiso(1, "ABM Usuario");
            BEPermiso p2 = new BEPermiso(2, "ABM Producto");
            BEPermiso p3 = new BEPermiso(3, "Cobranza");

            // Rol básico que agrupa dos permisos simples
            BERol rolCajero = new BERol(100, "Cajero");
            rolCajero.Agregar(p3);

            // Rol más grande que contiene permisos simples Y al rol Cajero adentro
            BERol rolGerente = new BERol(200, "Gerente");
            rolGerente.Agregar(p1);
            rolGerente.Agregar(p2);
            rolGerente.Agregar(rolCajero);   // ← un rol dentro de otro rol

            // Listamos lo que contiene el Gerente
            string txt = "Contenido del rol " + rolGerente.Nombre + ":\n";
            foreach (BEComposite hijo in rolGerente.ObtenerHijos())
            {
                txt += " - " + hijo.Nombre + "\n";
            }

            MessageBox.Show(txt);
        }
    }
}
