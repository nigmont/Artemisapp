using Artemisapp_BE.Animales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;

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

    // CRUDO: devuelve todos los nodos <Animal> sin mapear
    public List<XElement> ObtenerTodosCrudos()
    {
        InicializarXML();
        XDocument doc = XDocument.Load(ruta);
        return doc.Root.Elements("Animal").ToList();
    }

    // CRUDO: devuelve los nodos de los animales de un propietario (NroCte)
    public List<XElement> BuscarPorPropietarioCrudo(string nroCte)
    {
        InicializarXML();
        List<XElement> lista = new List<XElement>();
        XDocument doc = XDocument.Load(ruta);

        foreach (XElement elemento in doc.Root.Elements("Animal"))
        {
            if ((string)elemento.Element("NroCte") == nroCte)
                lista.Add(elemento);
        }
        return lista;
    }

    // CRUDO: devuelve el nodo de un animal por nombre + propietario
    public XElement BuscarPorNombreYPropietarioCrudo(string nombre, string nroCte)
    {
        InicializarXML();
        XDocument doc = XDocument.Load(ruta);

        foreach (XElement elemento in doc.Root.Elements("Animal"))
        {
            if ((string)elemento.Element("Nombre") == nombre &&
                (string)elemento.Element("NroCte") == nroCte)
                return elemento;
        }
        return null;
    }

    // CRUDO: recibe un nodo ya armado y lo guarda
    public bool GuardarCrudo(XElement nuevoAnimal)
    {
        try
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            doc.Root.Add(nuevoAnimal);
            doc.Save(ruta);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // CRUDO: elimina el nodo de un animal por nombre + propietario
    public bool EliminarCrudo(string nombre, string nroCte)
    {
        try
        {
            InicializarXML();
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
        catch
        {
            return false;
        }
    }

    // CRUDO: reemplaza el nodo existente (busca por Nombre + NroCte) por el nuevo
    public bool ActualizarCrudo(XElement animalActualizado)
    {
        try
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            string nombre = (string)animalActualizado.Element("Nombre");
            string nroCte = (string)animalActualizado.Element("NroCte");

            XElement elem = doc.Root.Elements("Animal")
                              .FirstOrDefault(x => (string)x.Element("Nombre") == nombre &&
                                                    (string)x.Element("NroCte") == nroCte);
            if (elem != null)
            {
                elem.ReplaceWith(animalActualizado);
                doc.Save(ruta);
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

}