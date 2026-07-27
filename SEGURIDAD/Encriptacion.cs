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
                string resultado = Convert.ToBase64String(encriptado);              
                return resultado;
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