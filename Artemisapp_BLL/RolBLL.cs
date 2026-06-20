using Artemisapp_BE.Composite;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class RolBLL
    {
        RolMapper mapper = new RolMapper();

        public bool RegistrarRol(BERol rol)
        {
            return mapper.Guardar(rol);
        }

        public BERol BuscarPorId(long id)
        {
            return mapper.BuscarPorId(id);
        }

        public List<BERol> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }
    }
}
