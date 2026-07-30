using Artemisapp_BE;
using Artemisapp_BE.Composite;
using Artemisapp_BLL;
using SEGURIDAD; // para poder usar la clase Encriptacion
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
    public partial class FormGestionAccesos : Form
    {
        public FormGestionAccesos()
        {
            InitializeComponent();
        }
        private string _usuarioSeleccionado = null;
        private BERol _rolSeleccionado = null;

        private void FormGestionAccesos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            CargarPermisos();
            CargarArbolRolesPermisos();
            CargarArbolUsuariosRolesPermisos();
        }

        private void CargarUsuarios()
        {
            lstUsuarios.Items.Clear(); // Limpiar la lista antes de cargar los usuarios
            UsuarioClaveBLL bll = new UsuarioClaveBLL();
            foreach (UsuarioClaves u in bll.ObtenerTodos()) // Iterar sobre la lista de usuarios
                                                            // obtenida del BLL
            {
                lstUsuarios.Items.Add(u.Usuario); // Agregar el nombre de usuario a la lista
            }
        }

        private void CargarRoles()
        {
            lstRoles.Items.Clear();
            RolBLL bll = new RolBLL();
            foreach (BERol r in bll.ObtenerTodos())
            {
                lstRoles.Items.Add(r.Nombre);
            }
        }

        private void CargarPermisos()
        {
            lstPermisos.Items.Clear();
            PermisoBLL bll = new PermisoBLL();
            foreach (BEPermiso p in bll.ObtenerTodos())
            {
                lstPermisos.Items.Add(p.Nombre);
            }
        }

        private void CargarArbolRolesPermisos()
        {
            treeRolesPermisos.Nodes.Clear();

            RolBLL rolBLL = new RolBLL();
            foreach (BERol rol in rolBLL.ObtenerTodos())
            {
                // Nodo padre: el rol
                TreeNode nodoRol = new TreeNode(rol.Nombre);

                // Nodos hijos: los permisos de ese rol
                foreach (BEComposite permiso in rol.ObtenerHijos())
                {
                    nodoRol.Nodes.Add(new TreeNode(permiso.Nombre));
                }

                treeRolesPermisos.Nodes.Add(nodoRol);
            }

            treeRolesPermisos.ExpandAll();   // arranca con todo desplegado
        }

        private void CargarArbolUsuariosRolesPermisos()
        {
            treeUsuariosRolesPermisos.Nodes.Clear();

            UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();
            foreach (UsuarioClaves usuario in usuarioBLL.ObtenerTodos())
            {
                // Nivel 1: el usuario
                TreeNode nodoUsuario = new TreeNode(usuario.Usuario);

                // Nivel 2: los roles del usuario
                foreach (BERol rol in usuario.Roles)
                {
                    TreeNode nodoRol = new TreeNode(rol.Nombre);

                    // Nivel 3: los permisos de ese rol
                    foreach (BEComposite permiso in rol.ObtenerHijos())
                    {
                        nodoRol.Nodes.Add(new TreeNode(permiso.Nombre));
                    }

                    nodoUsuario.Nodes.Add(nodoRol);
                }

                treeUsuariosRolesPermisos.Nodes.Add(nodoUsuario);
            }

            treeUsuariosRolesPermisos.ExpandAll();
        }


        // ---CREAR ROLES----
        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreRol.Text.Trim();

                // Validamos que se haya escrito un nombre
                if (nombre == "")
                {
                    MessageBox.Show("Escribí un nombre para el rol.");
                    return;
                }

                RolBLL rolBLL = new RolBLL();

                // Se genera un Id nuevo: el más alto que exista + 1
                long nuevoId = 1;
                foreach (BERol r in rolBLL.ObtenerTodos())
                {
                    if (r.Id >= nuevoId)
                        nuevoId = r.Id + 1;
                }

                // se crea el rol (nace sin permisos) y se guarda
                BERol nuevoRol = new BERol(nuevoId, nombre);
                rolBLL.RegistrarRol(nuevoRol);

                // se limpia el campo y se recarga la lista de roles
                txtNombreRol.Clear();
                CargarRoles();

                MessageBox.Show("Rol creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCrearPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombrePermiso.Text.Trim();

                if (nombre == "")
                {
                    MessageBox.Show("Escribí un nombre para el permiso.");
                    return;
                }

                PermisoBLL permisoBLL = new PermisoBLL();

                // Generamos un Id nuevo: el más alto que exista + 1
                long nuevoId = 1;
                foreach (BEPermiso p in permisoBLL.ObtenerTodos())
                {
                    if (p.Id >= nuevoId)
                        nuevoId = p.Id + 1;
                }

                // Creamos el permiso y lo guardamos
                BEPermiso nuevoPermiso = new BEPermiso(nuevoId, nombre);
                permisoBLL.RegistrarPermiso(nuevoPermiso);

                // Limpiamos el campo y recargamos la lista de permisos
                txtNombrePermiso.Clear();
                CargarPermisos();

                MessageBox.Show("Permiso creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtNuevoUsuario.Text.Trim();
                string password = txtNuevaPassword.Text;
                string dni = txtNuevoDni.Text.Trim();

                // Validamos que estén los datos mínimos
                if (usuario == "" || password == "")
                {
                    MessageBox.Show("Completá usuario y contraseña.");
                    return;
                }

                UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();

                // Verificamos que no exista ya un usuario con ese nombre de login
                if (usuarioBLL.ObtenerPorNombreUsuario(usuario) != null)
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre.");
                    return;
                }

                // Generamos un Id nuevo tipo U001, U002, etc.
                int cantidad = usuarioBLL.ObtenerTodos().Count;
                string nuevoId = "U" + (cantidad + 1).ToString("D3");

                // Creamos el usuario (nace activo, no bloqueado, sin roles)
                UsuarioClaves nuevo = new UsuarioClaves(nuevoId, usuario, password, dni, true, false);
                usuarioBLL.RegistrarUsuario(nuevo);

                // Limpiamos los campos y recargamos la lista de usuarios
                txtNuevoUsuario.Clear();
                txtNuevaPassword.Clear();
                txtNuevoDni.Clear();
                CargarUsuarios();

                MessageBox.Show("Usuario creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAsignarPermisoRol_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos que haya un rol y un permiso seleccionados
                if (lstRoles.SelectedItem == null || lstPermisos.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná un rol y un permiso.");
                    return;
                }

                string nombreRol = lstRoles.SelectedItem.ToString();
                string nombrePermiso = lstPermisos.SelectedItem.ToString();

                RolBLL rolBLL = new RolBLL();
                PermisoBLL permisoBLL = new PermisoBLL();

                // Buscamos el rol completo por su nombre
                BERol rol = null;
                foreach (BERol r in rolBLL.ObtenerTodos())
                {
                    if (r.Nombre == nombreRol)
                        rol = r;
                }

                // Buscamos el permiso completo por su nombre
                BEPermiso permiso = null;
                foreach (BEPermiso p in permisoBLL.ObtenerTodos())
                {
                    if (p.Nombre == nombrePermiso)
                        permiso = p;
                }

                if (rol == null || permiso == null)
                {
                    MessageBox.Show("No se encontró el rol o el permiso.");
                    return;
                }

                // Verificamos que el rol no tenga ya ese permiso
                foreach (BEComposite hijo in rol.ObtenerHijos())
                {
                    if (hijo.Id == permiso.Id)
                    {
                        MessageBox.Show("El rol ya tiene ese permiso.");
                        return;
                    }
                }

                // Le agregamos el permiso al rol y lo guardamos
                rol.Agregar(permiso);
                rolBLL.ActualizarRol(rol);

                MessageBox.Show("Permiso asignado al rol correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAsignarRolUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos que haya un usuario y un rol seleccionados
                if (lstUsuarios.SelectedItem == null || lstRoles.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná un usuario y un rol.");
                    return;
                }

                string nombreUsuario = lstUsuarios.SelectedItem.ToString();
                string nombreRol = lstRoles.SelectedItem.ToString();

                UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();
                RolBLL rolBLL = new RolBLL();

                // Buscamos el usuario completo
                UsuarioClaves usuario = usuarioBLL.ObtenerPorNombreUsuario(nombreUsuario);

                // Buscamos el rol completo
                BERol rol = null;
                foreach (BERol r in rolBLL.ObtenerTodos())
                {
                    if (r.Nombre == nombreRol)
                        rol = r;
                }

                if (usuario == null || rol == null)
                {
                    MessageBox.Show("No se encontró el usuario o el rol.");
                    return;
                }

                // Si el usuario ya tiene ese rol, lo quitamos para reemplazarlo por la versión actualizada
                usuario.Roles.RemoveAll(r => r.Id == rol.Id);

                usuario.Roles.Add(rol);
                usuarioBLL.ActualizarUsuario(usuario);

                MessageBox.Show("Rol asignado al usuario correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // encriptacion de password
        private void btnCifrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            
        }

        private void chbxEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxEncriptar.Checked)
            {
                // Si está marcado, encriptamos el texto actual
                string textoCifrado = SEGURIDAD.Encriptacion.EncriptarPassword(txtNuevaPassword.Text);
                txtNuevaPassword.Text = textoCifrado;
            }
            else
            {
                // Si se desmarcó, desencriptamos el texto actual
                string textoDescifrado = txtNuevaPassword.Text.DesencriptarPassword();
                txtNuevaPassword.Text = textoDescifrado;
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem == null) return;

            _usuarioSeleccionado = lstUsuarios.SelectedItem.ToString();

            UsuarioClaveBLL bll = new UsuarioClaveBLL();
            UsuarioClaves u = bll.ObtenerPorNombreUsuario(_usuarioSeleccionado);
            if (u != null)
            {
                txtNuevoUsuario.Text = u.Usuario;
                txtNuevoUsuario.Enabled = false; // el nombre de usuario es la clave, no se edita
                txtNuevaPassword.Clear();        // por seguridad, no mostramos la contraseña real
                txtNuevoDni.Text = u.Dni;
                chbxEncriptar.Checked = false;
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuarioSeleccionado == null)
                {
                    MessageBox.Show("Seleccioná un usuario de la lista para modificar.");
                    return;
                }

                UsuarioClaveBLL bll = new UsuarioClaveBLL();
                bool ok = bll.ModificarDatosUsuario(_usuarioSeleccionado, txtNuevaPassword.Text, txtNuevoDni.Text.Trim());

                if (ok)
                {
                    MessageBox.Show("Usuario modificado correctamente.");
                    LimpiarCamposUsuario();
                    CargarUsuarios();
                    CargarArbolUsuariosRolesPermisos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuarioSeleccionado == null)
                {
                    MessageBox.Show("Seleccioná un usuario de la lista para eliminar.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Eliminar al usuario \"" + _usuarioSeleccionado + "\"?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r != DialogResult.Yes) return;

                UsuarioClaveBLL bll = new UsuarioClaveBLL();
                bool ok = bll.EliminarUsuario(_usuarioSeleccionado);

                if (ok)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    LimpiarCamposUsuario();
                    CargarUsuarios();
                    CargarArbolUsuariosRolesPermisos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCamposUsuario()
        {
            txtNuevoUsuario.Clear();
            txtNuevoUsuario.Enabled = true;
            txtNuevaPassword.Clear();
            txtNuevoDni.Clear();
            _usuarioSeleccionado = null;
        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRoles.SelectedItem == null) return;

            string nombreRol = lstRoles.SelectedItem.ToString();

            RolBLL bll = new RolBLL();
            _rolSeleccionado = bll.ObtenerTodos().FirstOrDefault(r => r.Nombre == nombreRol);

            if (_rolSeleccionado != null)
            {
                txtNombreRol.Text = _rolSeleccionado.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rolSeleccionado == null)
                {
                    MessageBox.Show("Seleccioná un rol de la lista para modificar.");
                    return;
                }

                string nuevoNombre = txtNombreRol.Text.Trim();
                if (nuevoNombre == "")
                {
                    MessageBox.Show("El nombre del rol no puede estar vacío.");
                    return;
                }

                RolBLL bll = new RolBLL();
                bool ok = bll.ModificarNombreRol(_rolSeleccionado.Id, nuevoNombre);

                if (ok)
                {
                    MessageBox.Show("Rol modificado correctamente.");
                    LimpiarCamposRol();
                    CargarRoles();
                    CargarArbolRolesPermisos();
                    CargarArbolUsuariosRolesPermisos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el rol.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rolSeleccionado == null)
                {
                    MessageBox.Show("Seleccioná un rol de la lista para eliminar.");
                    return;
                }

                RolBLL bll = new RolBLL();

                string usuarioQueLoUsa;
                if (bll.RolEstaEnUso(_rolSeleccionado.Id, out usuarioQueLoUsa))
                {
                    MessageBox.Show(
                        "No se puede eliminar el rol \"" + _rolSeleccionado.Nombre +
                        "\" porque está asignado al usuario \"" + usuarioQueLoUsa + "\".\n" +
                        "Quitale ese rol primero.",
                        "Rol en uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Eliminar el rol \"" + _rolSeleccionado.Nombre + "\"?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r != DialogResult.Yes) return;

                bool ok = bll.EliminarRol(_rolSeleccionado.Id);

                if (ok)
                {
                    MessageBox.Show("Rol eliminado correctamente.");
                    LimpiarCamposRol();
                    CargarRoles();
                    CargarArbolRolesPermisos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el rol.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCamposRol()
        {
            txtNombreRol.Clear();
            _rolSeleccionado = null;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNuevoUsuario.Clear();
            txtNuevoUsuario.Enabled = true; // por si quedó bloqueado tras seleccionar un usuario para editar
            txtNuevaPassword.Clear();
            txtNuevoDni.Clear();
            txtNombreRol.Clear();

            chbxEncriptar.Checked = false;

            // Limpiamos también las selecciones activas, para que no queden
            // "colgadas" apuntando a un usuario/rol que ya no se está editando
            _usuarioSeleccionado = null;
            _rolSeleccionado = null;

            lstUsuarios.ClearSelected();
            lstRoles.ClearSelected();
        }

        private void btnActualizarArboles_Click(object sender, EventArgs e)
        {
            CargarArbolRolesPermisos();
            CargarArbolUsuariosRolesPermisos();
        }
    }
}
    