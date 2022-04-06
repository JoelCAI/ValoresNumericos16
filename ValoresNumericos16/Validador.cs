using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos16
{
    public class Validador
    {
        public static void CompararStringConNumeroInt(string str1)
        {
            string opcion = str1.Replace('.', ',');

            int nuevoUno;

            bool ok = int.TryParse(opcion, out nuevoUno);

            decimal numeroDos;

            bool okDos = decimal.TryParse(opcion, out numeroDos);


            if (ok)
            {
                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " Es un número Entero y es: " + "*" + nuevoUno + "*");

            }
            else if (okDos)
            {
                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " Es un número decimal " + "*" + numeroDos + "*" 
                                  + " pero no un número entero");
            }

            else
            {

                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " NO es un número ");
                Console.WriteLine("\n Recuerde ingresar un valor numérico si desea que el Sistema lo tome en cuenta");

            }
        }

        public static void MostrarString(string cadena)
        {

            Console.WriteLine("\n Usted escribio " + "*" + cadena + "*");

        }

      

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {

                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }






    }
}
