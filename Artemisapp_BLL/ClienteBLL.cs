using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemisapp_BE;
using Artemisapp_DAL; // Referencia a la capa de acceso a datos (DAL) para interactuar con el XML

namespace Artemisapp_BLL
{
    public class ClienteBLL
    {
        ClienteDAL dal = new ClienteDAL(); // Instancia de la clase DAL para acceder a los métodos de datos


        // REGISTRAR un nuevo cliente validando que el DNI no exista previamente.
        public bool RegistrarCliente(Cliente cli) { 
            return dal.GuardarCliente(cli); 
        }


        public Cliente BuscarClientePorDNI(string dni) { 
            return dal.BuscarPorDNI(dni); 
        }

        public bool actualizarDatos(Cliente cli) { 
            return dal.ActualizarCliente(cli); 
        }

        // ELIMINAR un cliente por DNI, eliminando también sus mascotas asociadas.
        // Recordar que dijo el profe que no se debe eliminar totalmente sino que bloquearlo o
        // marcarlo como inactivo, pero para este ejercicio se pide eliminarlo completamente.
        public bool eliminarCliente(string dni) { 
            return dal.EliminarCliente(dni); 
        }

        // OBTENER la lista de todos los clientes registrados.
        public List<Cliente> ObtenerTodos()
        {
            return dal.ObtenerTodos();
        }

    }
}
