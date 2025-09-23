using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imparmult5cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 != 0 && num % 5 == 0)
            {
                Console.WriteLine(num + " es impar y múltiplo de 5.");
            }
            else
            {
                if (num % 2 == 0 && num % 5 == 0)
                    Console.WriteLine(num + " es par y múltiplo de 5.");
                else if (num % 2 != 0 && num % 5 != 0)
                    Console.WriteLine(num + " es impar pero no múltiplo de 5.");
                else
                    Console.WriteLine(num + " es par y no múltiplo de 5.");
            }
        }
    }
}
