using Artemisapp_BE.Animales;
using Artemisapp_DAL;
using Artemisapp_MPP;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class AnimalBLL
    {
        AnimalDAL dal = new AnimalDAL();
        AnimalMapper mapper = new AnimalMapper();

        public bool RegistrarAnimal(Animal animal)
        {
            return mapper.Guardar(animal);
        }

        public bool ActualizarAnimal(Animal animal)
        {
            return mapper.Actualizar(animal);
        }

        public bool EliminarAnimal(string nombre, string nroCte)
        {
            return mapper.Eliminar(nombre, nroCte);
        }

        public Animal BuscarAnimal(string nombre, string nroCte)
        {
            return mapper.BuscarPorNombreYPropietario(nombre, nroCte);
        }

        public List<Animal> ObtenerAnimalesPorDNI(string dni)
        {
            return mapper.BuscarPorPropietario(dni);
        }
        public List<Animal> ObtenerTodos()
        {
            return mapper.ObtenerTodos();
        }
    }
}