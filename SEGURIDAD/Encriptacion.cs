using System;
using System.Text;

namespace SEGURIDAD
{
    public static class Encriptacion
    {
        public static string EncriptarPassword(string pPassword)
        {
            try
            {
                byte[] encriptado = Encoding.Unicode.GetBytes(pPassword);
                // encriptado hace que el password se convierta en un arreglo de bytes,
                // luego se convierte a base64 para que sea legible y se pueda almacenar en la bbdd
                
                string resultado = Convert.ToBase64String(encriptado);
                // resultado es el password encriptado en base64,
                // que es lo que se va a almacenar en la bbdd
                
                return resultado; // se retorna el password encriptado
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }

        public static string DesencriptarPassword(this string pPasswordEncriptado)
        {
            try
            {
                byte[] desencriptar = Convert.FromBase64String(pPasswordEncriptado);
                string resultado = Encoding.Unicode.GetString(desencriptar);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }
    }
}