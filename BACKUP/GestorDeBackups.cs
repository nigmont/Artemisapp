using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BACKUP
{
    public class GestorDeBackups
    {
        private string carpetaDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");

        private string carpetaBackups = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BACKUPS");

       
        public string RealizarBackup()
        {
            if (!Directory.Exists(carpetaBackups))
                Directory.CreateDirectory(carpetaBackups);

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture);

            string carpetaDestino = Path.Combine(carpetaBackups, timestamp);

            Directory.CreateDirectory(carpetaDestino);

            foreach (string archivo in Directory.GetFiles(carpetaDatos, "*.xml"))
            {
                string nombreArchivo = Path.GetFileName(archivo); // 
                string destino = Path.Combine(carpetaDestino, nombreArchivo);
                File.Copy(archivo, destino, true);
            }

            return timestamp; // se retorna el nombre de la carpeta de backup creada
        }




        // Devuelve la lista de backups disponibles (los nombres de las carpetas con timestamp)
        public List<string> ObtenerBackupsDisponibles()
        {
            List<string> lista = new List<string>();

            if (Directory.Exists(carpetaBackups))
            {
                foreach (string carpeta in Directory.GetDirectories(carpetaBackups)) 
                    // se recorre cada subcarpeta dentro de la carpeta de backups
                {
                    lista.Add(Path.GetFileName(carpeta));
                }
            }

            return lista;
        }




        // Restaura un backup: copia los XML de la carpeta elegida de vuelta a DATOS
        public void RestaurarBackup(string nombreBackup)
        {
            string carpetaOrigen = Path.Combine(carpetaBackups, nombreBackup);

            // Copiamos cada XML del backup de vuelta a la carpeta DATOS
            foreach (string archivo in Directory.GetFiles(carpetaOrigen, "*.xml"))
            {
                string nombreArchivo = Path.GetFileName(archivo);
                // nombreArchivo es el nombre del archivo XML (sin la ruta completa)

                string destino = Path.Combine(carpetaDatos, nombreArchivo);
                File.Copy(archivo, destino, true);
            }
        }

    }
}
