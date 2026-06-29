using Artemisapp_BE.Personas;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class VeterinarioBLL
    {
        VeterinarioMapper mapper = new VeterinarioMapper();

        public bool RegistrarVeterinario(Veterinario vet)
        {
            // Regla: no permitir dos veterinarios con el mismo DNI
            if (mapper.BuscarPorDNI(vet.DNI) != null)
                return false;

            return mapper.Guardar(vet);
        }

        public bool ActualizarVeterinario(Veterinario vet)
        {
            return mapper.Actualizar(vet);
        }

        public bool EliminarVeterinario(string dni)
        {
            return mapper.Eliminar(dni);
        }

        public Veterinario BuscarPorDNI(string dni)
        {
            return mapper.BuscarPorDNI(dni);
        }

        public List<Veterinario> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }
    }
}