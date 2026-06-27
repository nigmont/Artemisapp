using System;
using System.Globalization;
using System.IO;

namespace BACKUP
{
    public class GestorDeBackups
    {
        // carpeta donde estan los XML actuales (la base de datos)
        private string carpetaDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");

        // carpeta fija donde se guardan todos los backups
        private string carpetaBackups = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BACKUPS");

        // realiza un backup: copia todos los xml a una subcarpeta con el timestamp actual
        public string RealizarBackup()
        {
            // hay que asegurar que exista la carpeta de backups
            if (!Directory.Exists(carpetaBackups))
                Directory.CreateDirectory(carpetaBackups);

            // el nombre de la subcarpeta es la fecha y hora actual 
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture);

            string carpetaDestino = Path.Combine(carpetaBackups, timestamp);
            Directory.CreateDirectory(carpetaDestino);

            // Se copia cada archivo XML de Datos a la subcarpeta de backup
            foreach (string archivo in Directory.GetFiles(carpetaDatos, "*.xml")) 
            {
                string nombreArchivo = Path.GetFileName(archivo);
                string destino = Path.Combine(carpetaDestino, nombreArchivo);
                File.Copy(archivo, destino, true);
            }

            return timestamp; // se retorna el nombre de la carpeta de backup creada
        }

    }
}
