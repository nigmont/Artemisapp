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
    public partial class _04Clientes : Form
    {
        public _04Clientes()
        {
            InitializeComponent();

        }

        private void _04Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCte_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniCte.Text.Trim();

                if (dni == "")
                {
                    MessageBox.Show("Ingresá un DNI para buscar.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();
                Cliente c = bll.BuscarClientePorDNI(dni);

                if (c != null)
                {
                    // Cargamos los datos en los campos
                    txtNroCte.Text = c.NroCte;
                    txtNombreCte.Text = c.Nombre;
                    txtApellidoCte.Text = c.Apellido;
                    txtCorreoElectronicoCte.Text = c.Email;
                    txtTelefonoCte.Text = c.Telefono;
                    txtDireccionCte.Text = c.Direccion;
                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con ese DNI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiarCte_Click(object sender, EventArgs e)
        {
            // Se limpia el campo de búsqueda (DNI)
            txtDniCte.Clear();

            // Se limpian los campos donde se cargaron los datos del cliente
            txtNroCte.Clear();
            txtNombreCte.Clear();
            txtApellidoCte.Clear();
            txtCorreoElectronicoCte.Clear();
            txtTelefonoCte.Clear();
            txtDireccionCte.Clear();

            // Se deja el cursor listo en el campo DNI para una nueva búsqueda
            txtDniCte.Focus();
        }

        private void btnGuardarDatosCte_Click(object sender, EventArgs e)
        {
            try
            {
                // trim para eliminar espacios al inicio y al final
                string dni = txtDniCte.Text.Trim();
                string nombre = txtNombreCte.Text.Trim();
                string apellido = txtApellidoCte.Text.Trim();
                string email = txtCorreoElectronicoCte.Text.Trim();
                string telefono = txtTelefonoCte.Text.Trim();
                string direccion = txtDireccionCte.Text.Trim();

                // Validamos los datos mínimos
                if (dni == "" || nombre == "" || apellido == "")
                {
                    MessageBox.Show("Completá al menos DNI, Nombre y Apellido.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();

                // Verificamos que no exista ya un cliente con ese DNI
                if (bll.BuscarClientePorDNI(dni) != null)
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI.");
                    return;
                }

                // Generamos el Nro de Cliente automático (el más alto + 1, arrancando en 1001)
                int nuevoNro = 1001;
                foreach (Cliente cli in bll.ObtenerTodos())
                {
                    int nroExistente;
                    if (int.TryParse(cli.NroCte, out nroExistente) && nroExistente >= nuevoNro)
                        nuevoNro = nroExistente + 1;
                }

                // Creamos el cliente (con lista de mascotas vacía por ahora)
                Cliente nuevo = new Cliente(
                    dni,
                    nuevoNro.ToString(),
                    nombre,
                    apellido,
                    direccion,
                    telefono,
                    email,
                    new System.Collections.Generic.List<Artemisapp_BE.Animales.Animal>()
                );

                bll.RegistrarCliente(nuevo);

                // Mostramos el Nro generado y avisamos
                txtNroCte.Text = nuevoNro.ToString();
                MessageBox.Show("Cliente guardado correctamente. Nro de cliente: " + nuevoNro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
