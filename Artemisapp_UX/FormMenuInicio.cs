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

        // --- INICIO ---

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void manuCambiarUsuario_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Reinicia la aplicación para volver a la pantalla de login
        }

        // --- GESTIÓN DE USUARIOS ---
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionAccesos form = new FormGestionAccesos(); // Crear una instancia del formulario
            form.Show(); // Mostrar el formulario
        }

        // --- GESTIÓN DE CLIENTES ---
        private void menuClientes_Click(object sender, EventArgs e)
        {
            _04Clientes form = new _04Clientes(); // Crear una instancia del formulario
            form.Show(); // Mostrar el formulario
        }

        // --- GESTIÓN DE TURNOS ---
        private void menuTurnos_Click(object sender, EventArgs e)
        {
            _05Turnos form = new _05Turnos(); // Crear una instancia del formulario
            form.Show(); // Mostrar el formulario
        }

        //  --- GESTIÓN DE COBROS ---
        private void menuCobrarConsulta_Click(object sender, EventArgs e)
        {
            _07CobrarConsulta form = new _07CobrarConsulta(); // Crear una instancia del formulario
            form.Show(); // Mostrar el formulario
        }

        // -- GESTIÓN DE REPORTES ---
        // BACKUP, RESTORE, BITACORA
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _08aBackup form = new _08aBackup(_usuario);
            form.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _08bRestore form = new _08bRestore(_usuario);
            form.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _08cBitacora form = new _08cBitacora();
            form.Show();
        }

        // -- GRAFICOS DE TURNOS  ---
        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _09Dashboard form = new _09Dashboard();
            form.Show();
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            ProductoAlmacen form = new ProductoAlmacen(); // Crear una instancia del formulario
            form.Show();
        }

        private void menuHistoriaClinica_Click(object sender, EventArgs e)
        {
            HistoriaClinica form = new HistoriaClinica(); // Crear una instancia del formulario
            form.Show(); // Mostrar el formulario
        }
    }
}
