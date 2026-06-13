using Artemisapp_BE.Animales;
using Artemisapp_DAL;
using System.Collections.Generic;

namespace Artemisapp_BLL
{
    public class AnimalBLL
    {
        AnimalDAL dal = new AnimalDAL();

        public bool RegistrarAnimal(Animal animal)
        {
            return dal.GuardarAnimal(animal);
        }

        public bool ActualizarAnimal(Animal animal)
        {
            return false; // se implementará despues
        }

        public bool EliminarAnimal(string nombre, string nroCte)
        {
            return dal.EliminarAnimal(nombre, nroCte);
        }

        public Animal BuscarAnimal(string nombre, string nroCte)
        {
            return dal.BuscarPorNombreYPropietario(nombre, nroCte);
        }

        public List<Animal> ObtenerAnimalesPorDNI(string dni)
        {
            return dal.BuscarPorPropietario(dni);
        }
    }
}