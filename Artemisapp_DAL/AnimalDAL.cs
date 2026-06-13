using Artemisapp_BE.Animales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class AnimalDAL
{
    private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "Animales.xml");

    // Este método crea el archivo si no existe
    private void InicializarXML()
    {
        string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");

        // Crea la carpeta DATOS si no existe
        if (!Directory.Exists(carpeta))
            Directory.CreateDirectory(carpeta);

        // Crea el archivo XML si no existe
        if (!File.Exists(ruta))
        {
            XDocument doc = new XDocument(new XElement("Animales"));
            doc.Save(ruta);
        }
    }

    // GUARDAR un animal nuevo en el XML
    public bool GuardarAnimal(Animal animal)
    {
        try
        {
            InicializarXML(); // agregá esta línea al inicio
            XDocument doc = XDocument.Load(ruta);

            XElement nuevoAnimal = new XElement("Animal",
                new XElement("Nombre", animal.Nombre),
                new XElement("Edad", animal.Edad),
                new XElement("Peso", animal.Peso),
                new XElement("Raza", animal.Raza),
                new XElement("NroCte", animal.NroCte)
            );

            doc.Root.Add(nuevoAnimal);
            doc.Save(ruta);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    // OBTENER TODOS los animales del XML
    public List<Animal> ObtenerTodos()
    {
        InicializarXML(); // agregá esta línea al inicio
        List<Animal> lista = new List<Animal>();
        XDocument doc = XDocument.Load(ruta);
        foreach (XElement elemento in doc.Root.Elements("Animal"))
        {
            Animal a = new Animal(
                (string)elemento.Element("Nombre"),
                (int)elemento.Element("Edad"),
                (double)elemento.Element("Peso"),
                (string)elemento.Element("Raza"),
                (string)elemento.Element("NroCte")
            );
            lista.Add(a);
        }
        return lista;
    }

    // BUSCAR animales por NroCte
    public List<Animal> BuscarPorPropietario(string nroCte)
    {
        InicializarXML(); // agregá esta línea al inicio
        List<Animal> lista = new List<Animal>();
        XDocument doc = XDocument.Load(ruta);
        foreach (XElement elemento in doc.Root.Elements("Animal"))
        {
            if ((string)elemento.Element("NroCte") == nroCte)
            {
                Animal a = new Animal(
                    (string)elemento.Element("Nombre"),
                    (int)elemento.Element("Edad"),
                    (double)elemento.Element("Peso"),
                    (string)elemento.Element("Raza"),
                    (string)elemento.Element("NroCte")
                );
                lista.Add(a);
            }
        }
        return lista;
    }

    // BUSCAR un animal por nombre y propietario
    public Animal BuscarPorNombreYPropietario(string nombre, string nroCte)
    {
        InicializarXML(); // agregá esta línea al inicio
        XDocument doc = XDocument.Load(ruta);
        foreach (XElement elemento in doc.Root.Elements("Animal"))
        {
            if ((string)elemento.Element("Nombre") == nombre &&
                (string)elemento.Element("NroCte") == nroCte)
            {
                return new Animal(
                    (string)elemento.Element("Nombre"),
                    (int)elemento.Element("Edad"),
                    (double)elemento.Element("Peso"),
                    (string)elemento.Element("Raza"),
                    (string)elemento.Element("NroCte")
                );
            }
        }
        return null;
    }

    // ELIMINAR un animal por nombre y propietario
    public bool EliminarAnimal(string nombre, string nroCte)
    {
        try
        {
            InicializarXML(); // agregá esta línea al inicio
            XDocument doc = XDocument.Load(ruta);
            foreach (XElement elemento in doc.Root.Elements("Animal"))
            {
                if ((string)elemento.Element("Nombre") == nombre &&
                    (string)elemento.Element("NroCte") == nroCte)
                {
                    elemento.Remove();
                    doc.Save(ruta);
                    return true;
                }
            }
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}