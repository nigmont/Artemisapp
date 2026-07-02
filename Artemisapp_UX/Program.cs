using System;
using System.Windows.Forms;
using Artemisapp_BE;
using Artemisapp_BE.Composite;
using Artemisapp_BLL;

namespace Artemisapp_UX
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Crear permisos
            PermisoBLL permisoBLL = new PermisoBLL();
            permisoBLL.CrearPermisos();

            // 2. Crear rol Administrador
            RolBLL rolBLL = new RolBLL();
            rolBLL.CrearRolAdministrador();

            // 3. Crear el usuario admin con el rol Administrador
            UsuarioClaveBLL usuarioBLL = new UsuarioClaveBLL();
            if (usuarioBLL.ObtenerTodos().Count == 0)
            {
                UsuarioClaves admin = new UsuarioClaves("U001", "admin", "1234", "12345678", true, false);

                BERol rolAdmin = rolBLL.BuscarPorId(1);   // el rol Administrador tiene Id 1
                if (rolAdmin != null)
                    admin.Roles.Add(rolAdmin);

                usuarioBLL.RegistrarUsuario(admin);
            }

            Application.Run(new FormLogin());
        }
    }
}