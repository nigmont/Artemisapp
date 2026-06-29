using Artemisapp_BE;
using Artemisapp_BE.Personas;
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
    public partial class _05Turnos : Form
    {
        public _05Turnos()
        {
            InitializeComponent();
        }

        private void btnBuscarClienteTurno_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniTurno.Text.Trim();

                if (dni == "")
                {
                    MessageBox.Show("Ingresá un DNI para buscar.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();
                Cliente c = bll.BuscarClientePorDNI(dni);

                if (c != null)
                {
                    // Mostramos el nombre completo del cliente encontrado
                    txtClienteTurno.Text = c.Nombre + " " + c.Apellido;
                }
                else
                {
                    txtClienteTurno.Text = "";
                    MessageBox.Show("No se encontró un cliente con ese DNI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDniTurno.Clear();
            txtClienteTurno.Clear();
            
        }

        private void _05Turnos_Load(object sender, EventArgs e)
        {
            CargarProfesionales();
        }

        private void CargarProfesionales()
        {
            VeterinarioBLL vetBLL = new VeterinarioBLL();
            List<Veterinario> veterinarios = vetBLL.ObtenerTodos();

            cbProfesional.DataSource = veterinarios;
            cbProfesional.DisplayMember = "NombreCompletoConEspecialidad";
            cbProfesional.SelectedIndex = -1; // que arranque sin nada seleccionado
        }
    }
}
