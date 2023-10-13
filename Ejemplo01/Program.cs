using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string numeroA = getDato("Ingrese A: ");
            string numeroB = getDato("Ingrese B: "); 

            int resultado = multiplicar(numeroA, numeroB);

            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }

        private static string getDato(string value)
        {
            Console.Write(value);
            string numeroA = Console.ReadLine();
            return numeroA;
        }

        static int sumar(int a, int b) {

            return a + b;

        }

        static int multiplicar(string a , string b)
        {
            bool aCumple = validarEnteroMayorACero(a);
            bool bCumple = validarEnteroMayorACero(b);

            if (!aCumple) Console.WriteLine("A no es entero");
            if (!bCumple) Console.WriteLine("B no es entero");
            if (aCumple && bCumple)
            {

                int factor1 = int.Parse(a);
                int factor2 = int.Parse(b);

                return factor1 * factor2;
            }
            else
            {
                Console.WriteLine("No se puede multiplicar");
                return 0;
            }

        }

        static bool validarEnteroMayorACero(string numero)
        {
            int a = 0;
            bool esEntero = int.TryParse(numero, out a);
            bool esMayorACero = a > 0;

            return esEntero && esMayorACero;
        }


    }
}
