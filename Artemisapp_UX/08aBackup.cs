using Artemisapp_BE;
using Artemisapp_BLL;
using BACKUP;
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
    public partial class _08aBackup : Form
    {
        private UsuarioClaves _usuario;

        public _08aBackup(UsuarioClaves usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void btnRealizarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Hacemos el backup (copia todos los XML a una carpeta con timestamp)
                GestorDeBackups gestor = new GestorDeBackups();
                string timestamp = gestor.RealizarBackup();

                // 2. Registramos el evento en la bitácora con el usuario logueado real
                Bitacora bitacora = new Bitacora();
                EventoBitacora evento = new EventoBitacora(DateTime.Now, _usuario.Usuario, "Backup");
                bitacora.RegistrarEvento(evento);

                // 3. Avisamos al usuario
                lblResultadoBackup.Text = "Backup realizado: " + timestamp;
                MessageBox.Show("Backup realizado correctamente.\nCarpeta: " + timestamp);
                CargarHistorialBackups();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el backup: " + ex.Message);
            }
        }

        private void _08aBackup_Load(object sender, EventArgs e)
        {
            CargarHistorialBackups();
        }

        private void CargarHistorialBackups()
        {
            Bitacora bitacora = new Bitacora();
            List<EventoBitacora> eventos = bitacora.ObtenerTodos();

            // Solo los eventos de tipo "Backup"
            eventos = eventos.Where(ev => ev.Evento == "Backup").ToList();

            dgvBackups.DataSource = null;
            dgvBackups.DataSource = eventos.Select(ev => new
            {
                FechaRegistro = ev.FechaHora,
                Detalle = ev.Evento,
                Usuario = ev.Usuario
            }).ToList();
        }

        private void dgvBackups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBackups.CurrentRow != null)
            {
                string nombreUsuario = dgvBackups.CurrentRow.Cells["Usuario"].Value?.ToString();
                txtUsuarioBackup.Text = nombreUsuario;

                // Buscamos el usuario completo para mostrar su Id
                UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();
                UsuarioClaves usuario = usuarioBLL.ObtenerPorNombreUsuario(nombreUsuario);

                if (usuario != null)
                    txtIdUsuarioBackup.Text = usuario.Id;
                else
                    txtIdUsuarioBackup.Text = "";
            }
        }

        private void btnLimpiarBackup_Click(object sender, EventArgs e)
        {
            txtIdUsuarioBackup.Clear();
            txtUsuarioBackup.Clear();
            lblResultadoBackup.Text = "";
        }

        private void btnSalirBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}