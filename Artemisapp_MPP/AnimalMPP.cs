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
            string tipo = (string)elemento.Element("Tipo");

            string nombre = (string)elemento.Element("Nombre");
            int edad = (int)elemento.Element("Edad");
            double peso = (double)elemento.Element("Peso");
            string raza = (string)elemento.Element("Raza");
            string nroCte = (string)elemento.Element("NroCte");

            if (tipo == "Perro")
                return new Perro(nombre, edad, peso, raza, nroCte,
                    (bool?)elemento.Element("Castrado") ?? false,
                    (bool?)elemento.Element("Vacunado") ?? false,
                    (bool?)elemento.Element("Medicado") ?? false);

            if (tipo == "Gato")
                return new Gato(nombre, edad, peso, raza, nroCte,
                    (bool?)elemento.Element("Castrado") ?? false,
                    (bool?)elemento.Element("Vacunado") ?? false,
                    (bool?)elemento.Element("Medicado") ?? false);

            // Sin tipo (animales viejos) o Tipo="Animal" → Animal base
            return new Animal(nombre, edad, peso, raza, nroCte);
        }

        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Animal animal)
        {
            XElement nodo = new XElement("Animal",
        new XElement("Nombre", animal.Nombre),
        new XElement("Edad", animal.Edad),
        new XElement("Peso", animal.Peso),
        new XElement("Raza", animal.Raza),
        new XElement("NroCte", animal.NroCte)
    );

            if (animal is Perro perro)
            {
                nodo.Add(new XElement("Tipo", "Perro"));
                nodo.Add(new XElement("Castrado", perro.Castrado));
                nodo.Add(new XElement("Vacunado", perro.Vacunado));
                nodo.Add(new XElement("Medicado", perro.Medicado));
            }
            else if (animal is Gato gato)
            {
                nodo.Add(new XElement("Tipo", "Gato"));
                nodo.Add(new XElement("Castrado", gato.Castrado));
                nodo.Add(new XElement("Vacunado", gato.Vacunado));
                nodo.Add(new XElement("Medicado", gato.Medicado));
            }
            else
            {
                nodo.Add(new XElement("Tipo", "Animal"));
            }

            return nodo;
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

        public bool Actualizar(Animal animal)
        {
            AnimalDAL dal = new AnimalDAL();
            XElement animalActualizado = ToXml(animal);
            return dal.ActualizarCrudo(animalActualizado);
        }

    }
}
