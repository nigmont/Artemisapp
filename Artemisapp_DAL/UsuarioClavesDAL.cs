using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Artemisapp_DAL
{
    public class UsuarioClavesDAL
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS", "UsuariosClaves.xml");
        // Asegura que el archivo XML exista antes de cualquier operación
        // ruta será algo como "C:\Path\To\App\DATOS\UsuariosClaves.xml"
        // path.combine se encarga de construir la ruta correctamente según el sistema operativo
        // appdomain.currentdomain.baseDirectory devuelve la ruta donde se ejecuta la aplicación,
        // lo que hace que el código sea más portable

        private void InicializarXML()
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
            if (!Directory.Exists(carpeta)) // Si la carpeta "DATOS" no existe, la crea
                Directory.CreateDirectory(carpeta); // Esto asegura que la carpeta exista antes de intentar crear el archivo XML
            if (!File.Exists(ruta)) // Si el archivo XML no existe, lo crea con la estructura básica
            {
                XDocument doc = new XDocument(new XElement("UsuariosClaves"));
                // El método Save se encarga de crear el archivo si no existe, o sobrescribirlo si ya existe
                doc.Save(ruta);
                // Esto garantiza que siempre haya un archivo XML con la estructura correcta antes de
                // cualquier operación de lectura o escritura
            }
        }

        // CRUDO: devuelve todos los nodos <UsuarioClaves> sin mapear
        public List<XElement> ObtenerTodosCrudos()
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("UsuarioClaves").ToList();
        }

        // CRUDO: devuelve el nodo de un usuario por nombre de usuario
        public XElement BuscarPorNombreUsuarioCrudo(string nombreUsuario)
        {
            InicializarXML();
            XDocument doc = XDocument.Load(ruta);
            return doc.Root.Elements("UsuarioClaves")
                      .FirstOrDefault(x => (string)x.Element("Usuario") == nombreUsuario);
        }

        // CRUDO: recibe un nodo ya armado y lo guarda
        public bool GuardarCrudo(XElement nuevoUsuario)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                doc.Root.Add(nuevoUsuario);
                doc.Save(ruta);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // CRUDO: reemplaza el usuario existente (busca por Usuario) por el nuevo
        public bool ActualizarCrudo(XElement usuarioActualizado)
        {
            try
            {
                InicializarXML();
                XDocument doc = XDocument.Load(ruta);
                string nombreUsuario = (string)usuarioActualizado.Element("Usuario");

                XElement elem = doc.Root.Elements("UsuarioClaves")
                                  .FirstOrDefault(x => (string)x.Element("Usuario") == nombreUsuario);
                if (elem != null)
                {
                    elem.ReplaceWith(usuarioActualizado);
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
}
