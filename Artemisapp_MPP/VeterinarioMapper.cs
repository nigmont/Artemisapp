using System.Collections.Generic;
using System.Xml.Linq;
using Artemisapp_BE.Personas;
using Artemisapp_DAL;

namespace Artemisapp_MPP
{
    public class VeterinarioMapper
    {
        // De entidad de negocio → dato crudo (XML)
        public XElement ToXml(Veterinario vet)
        {
            return new XElement("Veterinario",
                new XElement("DNI", vet.DNI),
                new XElement("Nombre", vet.Nombre),
                new XElement("Apellido", vet.Apellido),
                new XElement("Telefono", vet.Telefono),
                new XElement("Correo", vet.Correo),
                new XElement("NroLicencia", vet.NroLicencia),
                new XElement("Especialidad", vet.Especialidad)
            );
        }

        // De dato crudo (XML) → entidad de negocio
        public Veterinario ToEntity(XElement elem)
        {
            return new Veterinario(
                (string)elem.Element("Nombre"),
                (string)elem.Element("Apellido"),
                (string)elem.Element("DNI"),
                (string)elem.Element("Telefono"),
                (string)elem.Element("Correo"),
                (string)elem.Element("NroLicencia"),
                (string)elem.Element("Especialidad")
            );
        }

        public List<Veterinario> ObtenerTodos()
        {
            VeterinarioDAL dal = new VeterinarioDAL();
            List<Veterinario> lista = new List<Veterinario>();

            foreach (XElement elem in dal.ObtenerTodosCrudos())
            {
                lista.Add(ToEntity(elem));
            }

            return lista;
        }

        public Veterinario BuscarPorDNI(string dni)
        {
            VeterinarioDAL dal = new VeterinarioDAL();
            XElement elem = dal.BuscarPorDNICrudo(dni);

            if (elem == null)
                return null;

            return ToEntity(elem);
        }

        public bool Guardar(Veterinario vet)
        {
            VeterinarioDAL dal = new VeterinarioDAL();
            XElement nuevo = ToXml(vet);
            return dal.GuardarCrudo(nuevo);
        }

        public bool Actualizar(Veterinario vet)
        {
            VeterinarioDAL dal = new VeterinarioDAL();
            XElement actualizado = ToXml(vet);
            return dal.ActualizarCrudo(actualizado);
        }

        public bool Eliminar(string dni)
        {
            VeterinarioDAL dal = new VeterinarioDAL();
            return dal.EliminarCrudo(dni);
        }
    }
}