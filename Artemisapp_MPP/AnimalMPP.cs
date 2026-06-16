using System.Collections.Generic;
using System.Xml.Linq;
using Artemisapp_BE.Animales;

namespace Artemisapp_MPP
{
    public class AnimalMapper
    {
        // De dato crudo (XML) → entidad de negocio
        public Animal ToEntity(XElement elemento)
        {
            return new Animal(
                (string)elemento.Element("Nombre"),
                (int)elemento.Element("Edad"),
                (double)elemento.Element("Peso"),
                (string)elemento.Element("Raza"),
                (string)elemento.Element("NroCte")
            );
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Animal animal)
        {
            return new XElement("Animal",
                new XElement("Nombre", animal.Nombre),
                new XElement("Edad", animal.Edad),
                new XElement("Peso", animal.Peso),
                new XElement("Raza", animal.Raza),
                new XElement("NroCte", animal.NroCte)
            );
        }

        public List<Animal> ObtenerTodos()
        {
            AnimalDAL dal = new AnimalDAL();
            List<Animal> lista = new List<Animal>();

            foreach (XElement elemento in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elemento));
            }

            return lista;
        }

        public List<Animal> BuscarPorPropietario(string nroCte)
        {
            AnimalDAL dal = new AnimalDAL();
            List<Animal> lista = new List<Animal>();

            foreach (XElement elemento in dal.BuscarPorPropietarioCrudo(nroCte))
            {
                lista.Add(ToEntity(elemento));
            }

            return lista;
        }

        public Animal BuscarPorNombreYPropietario(string nombre, string nroCte)
        {
            AnimalDAL dal = new AnimalDAL();
            XElement elemento = dal.BuscarPorNombreYPropietarioCrudo(nombre, nroCte);

            if (elemento == null)
                return null;

            return ToEntity(elemento);
        }

        public bool Guardar(Animal animal)
        {
            AnimalDAL dal = new AnimalDAL();
            XElement nuevoAnimal = ToXml(animal);
            return dal.GuardarCrudo(nuevoAnimal);
        }

        public bool Eliminar(string nombre, string nroCte)
        {
            AnimalDAL dal = new AnimalDAL();
            return dal.EliminarCrudo(nombre, nroCte);
        }
   
    }
}
