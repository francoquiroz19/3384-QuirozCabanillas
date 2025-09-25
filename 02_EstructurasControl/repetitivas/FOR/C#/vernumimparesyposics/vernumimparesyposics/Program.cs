using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vernumimparesyposics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que lea n números enteros y muestre cuántos son impares y positivos*/

            int n, numero, contador = 0;

            Console.WriteLine("Ingrese la cantidad de números: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine($"Ingrese número {i} :");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0 && numero % 2 != 0)
                {
                    contador++;
                }

            }
            Console.WriteLine($"La cantidad de números positivos enteros es {contador}");
        }
    }
}
