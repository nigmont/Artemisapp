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
    public partial class _08cBitacora : Form
    {
        public _08cBitacora()
        {
            InitializeComponent();
        }

        private void _08cBitacora_Load(object sender, EventArgs e)
        {
            CargarBitacora(); // Se carga la bitácora al iniciar el formulario
        }

            private void CargarBitacora()
        {
            BACKUP.Bitacora bitacora = new BACKUP.Bitacora();
            //bitacora es una instancia de la clase Bitacora que se encarga de
            //manejar los eventos de la bitácora.

            System.Collections.Generic.List<BACKUP.EventoBitacora> eventos = bitacora.ObtenerTodos();

            // Filtro según el radio button seleccionado
            if (rbSoloBackups.Checked)
                eventos = eventos.Where(ev => ev.Evento == "Backup").ToList();
            else if (rbSoloRestores.Checked)
                eventos = eventos.Where(ev => ev.Evento == "Restore").ToList();

            // Se muestra en la grilla con nombres de columna lindos
            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = eventos.Select(ev => new
            {
                FechaRegistro = ev.FechaHora,
                Detalle = ev.Evento,
                Usuario = ev.Usuario
            }).ToList();
        }

        private void btnRecargarBitacora_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void btnExitBitacora_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbSoloBackups_CheckedChanged(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void rbSoloRestores_CheckedChanged(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void dgvBitacora_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBitacora.CurrentRow != null)
            {
                string nombreUsuario = dgvBitacora.CurrentRow.Cells["Usuario"].Value?.ToString();
                txtUsuarioBitacora.Text = nombreUsuario;

                // Buscamos el usuario completo para mostrar su Id
                UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();
                UsuarioClaves usuario = usuarioBLL.ObtenerPorNombreUsuario(nombreUsuario);

                if (usuario != null)
                    txtIdUsuarioBitacora.Text = usuario.Id;
                else
                    txtIdUsuarioBitacora.Text = "";
            }
        }
    }
}
