using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public static class Funciones
    {

        public static List<int> StringToIntList(string listaString)
        {
            string[] elementos = listaString.Split(';');
            List<int> listaDeEnteros = new List<int>();
            foreach (string elemento in elementos)
            {
                if (int.TryParse(elemento, out int entero))
                {
                    listaDeEnteros.Add(entero);
                }
                else
                {
                    throw new ExcepcionConstruyendoEntidad();
                }
            }
            return listaDeEnteros;
        }

        public static string IntListToString(List<int> listaInt)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int entero in listaInt){
                sb.Append(entero.ToString());
                sb.Append(';');
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static void imprimirErrores(Exception ex)
        {
            Console.WriteLine("Error principal:");
            Console.WriteLine(ex.Message);
            Exception innerException = ex.InnerException;
            int innerExceptionCount = 1;
            while (innerException != null)
            {
                Console.WriteLine($"Error interno {innerExceptionCount}:");
                Console.WriteLine(innerException.Message);

                innerException = innerException.InnerException;
                innerExceptionCount++;
            }
        }

    }


}
