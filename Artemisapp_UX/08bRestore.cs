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
    public partial class _08bRestore : Form
    {
        private UsuarioClaves _usuario;
        public _08bRestore(UsuarioClaves usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }


        private void _08bRestore_Load(object sender, EventArgs e)
        {
            CargarBackupsDisponibles();
        }

        private void CargarBackupsDisponibles()
        {
            GestorDeBackups gestor = new GestorDeBackups();
            lstBackups.DataSource = null;
            lstBackups.DataSource = gestor.ObtenerBackupsDisponibles();
        }

        private void btnRealizarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos que haya un backup seleccionado
                if (lstBackups.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná un backup de la lista.");
                    return;
                }       

                string nombreBackup = lstBackups.SelectedItem.ToString();

                // Confirmamos, porque el restore reemplaza los datos actuales
                DialogResult respuesta = MessageBox.Show(
                    "¿Seguro que querés restaurar este backup?\nLos datos actuales se reemplazarán por los del backup:\n" + nombreBackup,
                    "Confirmar Restore",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta != DialogResult.Yes)
                    return;

                // 1. Restauramos el backup elegido
                GestorDeBackups gestor = new GestorDeBackups();
                gestor.RestaurarBackup(nombreBackup);

                // 2. Registramos el evento en la bitácora
                Bitacora bitacora = new Bitacora();
                EventoBitacora evento = new EventoBitacora(DateTime.Now, _usuario.Usuario, "Restore");
                bitacora.RegistrarEvento(evento);

                MessageBox.Show("Restore realizado correctamente.\nSe restauró el backup: " + nombreBackup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el restore: " + ex.Message);
            }
        }

        private void btnRecargarBackups_Click(object sender, EventArgs e)
        {
            CargarBackupsDisponibles();
        }

        private void btnSalirRestore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
