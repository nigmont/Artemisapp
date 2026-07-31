using Artemisapp_BE;
using Artemisapp_BE.Animales;
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
            CargarListadoClientes();
        }

        private void CargarListadoClientes()
        {
            ClienteBLL bll = new ClienteBLL();
            dtgvListadoCtes.DataSource = null;
            dtgvListadoCtes.DataSource = bll.ObtenerTodos();
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

                    // Mostramos el resumen en el label
                    lblMostrarInfoCliente.Text =
                        "N° de cliente: " + c.NroCte + "\n" +
                        "DNI: " + c.Dni + "\n" +
                        "Nombre: " + c.Nombre + " " + c.Apellido + "\n" +
                        "Correo: " + c.Email + "\n" +
                        "Teléfono: " + c.Telefono + "\n" +
                        "Dirección: " + c.Direccion;

                    CargarMascotasDelCliente(c.NroCte);

                }
                else
                {
                    MessageBox.Show("No hay ningún cliente registrado con ese DNI. Por favor, complete los siguientes datos para darlo de alta en el sistema.");
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
 
            txtNombreCte.Clear();
            txtApellidoCte.Clear();
            txtCorreoElectronicoCte.Clear();
            txtTelefonoCte.Clear();
            txtDireccionCte.Clear();
            lblMostrarInfoCliente.Text = "Información del Cliente";

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
                    new System.Collections.Generic.List<Artemisapp_BE.Animales.Animal>(),
                    true
                );

                bll.RegistrarCliente(nuevo);

                // Mostramos el resumen del cliente en el label
                lblMostrarInfoCliente.Text =
                    "N° de cliente: " + nuevoNro + "\n" +
                    "DNI: " + dni + "\n" +
                    "Nombre: " + nombre + " " + apellido + "\n" +
                    "Correo: " + email + "\n" +
                    "Teléfono: " + telefono + "\n" +
                    "Dirección: " + direccion;

                MessageBox.Show("Cliente guardado correctamente. Nro de cliente: " + nuevoNro);
                CargarListadoClientes();
                txtNroCte.Text = nuevoNro.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniCte.Text.Trim();

                if (dni == "")
                {
                    MessageBox.Show("Buscá un cliente por DNI primero.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();
                Cliente existente = bll.BuscarClientePorDNI(dni);

                if (existente == null)
                {
                    MessageBox.Show("No existe un cliente con ese DNI.");
                    return;
                }

                // Creamos el cliente con los datos editados (mismo DNI y NroCte, conservamos las mascotas)
                Cliente modificado = new Cliente(
                    dni,
                    existente.NroCte,
                    txtNombreCte.Text.Trim(),
                    txtApellidoCte.Text.Trim(),
                    txtDireccionCte.Text.Trim(),
                    txtTelefonoCte.Text.Trim(),
                    txtCorreoElectronicoCte.Text.Trim(),
                    existente.Mascotas,
                    existente.Activo
                );

                bll.actualizarDatos(modificado);

                MessageBox.Show("Datos del cliente modificados correctamente.");
                CargarListadoClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniCte.Text.Trim();
                if (dni == "")
                {
                    MessageBox.Show("Buscá un cliente por DNI primero.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();
                Cliente c = bll.BuscarClientePorDNI(dni);

                if (c == null)
                {
                    MessageBox.Show("No existe un cliente con ese DNI.");
                    return;
                }

                if (c.Activo == false)
                {
                    MessageBox.Show("Ese cliente ya está inactivo.");
                    return;
                }

                DialogResult r = MessageBox.Show("¿Dar de baja al cliente " + c.Nombre + " " + c.Apellido + "?",
                    "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;

                Cliente inactivo = new Cliente(
                    c.Dni, c.NroCte, c.Nombre, c.Apellido, c.Direccion, c.Telefono, c.Email, c.Mascotas, false
                );

                bll.actualizarDatos(inactivo);
                MessageBox.Show("Cliente dado de baja correctamente.");
                CargarListadoClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAgregarMascota form = new FormAgregarMascota(txtNroCte.Text);
            form.Show();
        }

        private void CargarMascotasDelCliente(string nroCte)
        {
            AnimalBLL bll = new AnimalBLL();
            dtgvMascotaAsociadaCliente.DataSource = null;
            dtgvMascotaAsociadaCliente.DataSource = bll.ObtenerAnimalesPorDNI(nroCte);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Verificar que haya un cliente cargado
                if (txtNroCte.Text.Trim() == "")
                {
                    MessageBox.Show("Primero buscá un cliente.");
                    return;
                }

                // 2. Verificar que haya una mascota seleccionada en la grilla
                if (dtgvMascotaAsociadaCliente.CurrentRow == null ||
                    !(dtgvMascotaAsociadaCliente.CurrentRow.DataBoundItem is Animal mascota))
                {
                    MessageBox.Show("Seleccioná una mascota de la lista para eliminar.");
                    return;
                }

                // 3. Confirmación antes de borrar
                DialogResult r = MessageBox.Show(
                    "¿Eliminar a " + mascota.Nombre + " de la lista de mascotas?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                    return;

                // 4. Eliminar y refrescar
                AnimalBLL bll = new AnimalBLL();
                bool ok = bll.EliminarAnimal(mascota.Nombre, txtNroCte.Text.Trim());

                if (ok)
                {
                    MessageBox.Show("Mascota eliminada correctamente.");
                    CargarMascotasDelCliente(txtNroCte.Text.Trim());
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la mascota.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // modif mascota
        {
            if (txtNroCte.Text.Trim() == "")
            {
                MessageBox.Show("Primero buscá un cliente.");
                return;
            }

            if (dtgvMascotaAsociadaCliente.CurrentRow == null ||
                !(dtgvMascotaAsociadaCliente.CurrentRow.DataBoundItem is Animal mascota))
            {
                MessageBox.Show("Seleccioná una mascota de la lista para modificar.");
                return;
            }

            FormAgregarMascota form = new FormAgregarMascota(txtNroCte.Text.Trim(), mascota);
            form.ShowDialog(this);

            CargarMascotasDelCliente(txtNroCte.Text.Trim());
        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniCte.Text.Trim();
                if (dni == "")
                {
                    MessageBox.Show("Buscá un cliente por DNI primero.");
                    return;
                }

                ClienteBLL bll = new ClienteBLL();
                Cliente c = bll.BuscarClientePorDNI(dni);

                if (c == null)
                {
                    MessageBox.Show("No existe un cliente con ese DNI.");
                    return;
                }

                if (c.Activo == true)
                {
                    MessageBox.Show("Ese cliente ya está activo.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Reactivar al cliente " + c.Nombre + " " + c.Apellido + "?",
                    "Confirmar reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;

                Cliente activo = new Cliente(
                    c.Dni, c.NroCte, c.Nombre, c.Apellido, c.Direccion, c.Telefono, c.Email, c.Mascotas, true
                );

                bll.actualizarDatos(activo);
                MessageBox.Show("Cliente reactivado correctamente.");
                CargarListadoClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
