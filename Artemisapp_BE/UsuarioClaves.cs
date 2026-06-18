using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisapp_BE
{
    public class UsuarioClaves
    {
        private string _id;
        private string _usuario;
        private string _password;
        private string _dni;
        private bool _activo;
        private bool _bloqueado;

        public string Id { get => _id; set => _id = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Password { get => _password; set => _password = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public bool Bloqueado { get => _bloqueado; set => _bloqueado = value; }

        public UsuarioClaves(string id, string usuario, string password, string dni, bool activo, bool bloqueado)
        {
            _id = id;
            _usuario = usuario;
            _password = password;
            _dni = dni;
            _activo = activo;
            _bloqueado = bloqueado;
        }
    }
}
